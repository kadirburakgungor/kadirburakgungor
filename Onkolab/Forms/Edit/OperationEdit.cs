using EasyModbus;
using Onkolab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onkolab.Forms.Edit
{
    public partial class OperationEdit : EMGForm
    {
        public OperationEdit()
        {
            InitializeComponent();
        }
        ModbusClient modbusClient = new ModbusClient("COM15");
        int asama = 0;
        int tmrAsama = 0;
        int currentSise = 0;
        int currentCekim = 0;


        OnkolabDb db = new OnkolabDb();
        public Operations obj = new Operations();
        String mesaj = "Operasyon";
        PrescriptionItems prescriptionItems = new PrescriptionItems();
        List<OperationItems> siseListesi = new List<OperationItems>();
        DataTable table = new DataTable();
        DataTable flakomTable = new DataTable();
        DataTable tartıTable = new DataTable();


        DataTable tableOperationItems = new DataTable();
        double uygulanacakDoz = 0;
        double topValue = 0;
        double botValue = 0;
        double stepValue = 0;

        double ilkOkumaFlakomDeger = 0;
        double sonOkumaFlakomDeger = 0;



        bool ilkOkumaFlakom = false;
        private void OperationEdit_Load(object sender, EventArgs e)
        {


            obj = db.Operations.FirstOrDefault(a => a.Id == obj.Id);
            table.Columns.Add("Method");
            table.Columns.Add("İslem");
            table.Columns.Add("Hareket_Noktası");

            flakomTable.Columns.Add("Okuma");
            flakomTable.Columns.Add("Deger");

            tartıTable.Columns.Add("Okuma");
            tartıTable.Columns.Add("Deger");



            modbusClient.UnitIdentifier = 1;
            modbusClient.Baudrate = 9600;
            modbusClient.Parity = System.IO.Ports.Parity.None;
            modbusClient.StopBits = System.IO.Ports.StopBits.Two;
            modbusClient.ConnectionTimeout = 500;
            modbusClient.Connect();
            serialPort1.PortName = "COM3";// hangi porta bagladıgına bak.
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            siseListesi = db.OperationItems.Where(a => a.OperationId == obj.Id).ToList();


            tableOperationItems.Columns.Add("İlac_Adı");
            tableOperationItems.Columns.Add("Enjektor");
            tableOperationItems.Columns.Add("Sefer_Sayısı");

            for (int i = 0; i < siseListesi.Count; i++)
            {
                try
                {

                    DataRow dr = tableOperationItems.NewRow();
                    OperationItems operationItems = siseListesi[i];


                    Medicines ilac = db.Medicines.FirstOrDefault(item => item.Id == operationItems.MedicineId);
                    Injectors enjektor = db.Injectors.FirstOrDefault(item => item.Id == operationItems.InjektorId);

                    dr["İlac_Adı"] = ilac.Name;
                    dr["Enjektor"] = enjektor.Capacity;
                    dr["Sefer_Sayısı"] = siseListesi[i].TripCounter;

                    tableOperationItems.Rows.Add(dr);
                }
                catch (Exception ex)
                {

                    throw;
                }


            }


            prescriptionItems = db.PrescriptionItems.FirstOrDefault(a => a.EtkenMaddeId == obj.EtkenMaddeId && a.PrescriptionId == obj.PrescriptionId);
            uygulanacakDoz = prescriptionItems.UygulanacakDoz.ToDbl();

            GControlItems.DataSource = tableOperationItems;
            tmrHome.Start();
        }

        private void tmrHome_Tick(object sender, EventArgs e)
        {
            if (asama == 0)
            {


                modbusClient.WriteSingleCoil(26, true);//home true gönderiyor.
                bool[] gelenx14 = modbusClient.ReadCoils(14, 1);
                bool[] geleny18 = modbusClient.ReadCoils(18, 1);
                bool[] gelenz23 = modbusClient.ReadCoils(23, 1);
                tmrAsama++;

                if (gelenx14[0] == true && geleny18[0] == true && gelenz23[0] == true && tmrAsama > 25)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "HOME";
                    dr["İslem"] = "ASAMA-1";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    //modbusClient.WriteSingleCoil(26, false);//home false
                    asama = 1;
                    tmrAsama = 0;
                }
            }
            else if (asama == 1)
            {
                modbusClient.WriteSingleRegister(0, 16);
                bool[] zYukarda = modbusClient.ReadCoils(30, 1);
                tmrAsama++;
                //if (tmrAsama > 25 && zYukarda[0])
                //{
                //    tmrAsama = 0;
                //    asama = 2;
                //}


                if (tmrAsama > 25 && zYukarda[0])
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "HOME";
                    dr["İslem"] = "ASAMA-2";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 2;
                }
            }
            else if (asama == 2)
            {
                modbusClient.WriteSingleRegister(13, 10200);//y itiyor
                modbusClient.WriteSingleRegister(11, 3000);
                modbusClient.WriteSingleCoil(6, true);
                bool[] yBaslangic = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                //if (tmrAsama > 25 && yBaslangic[0] == true)
                //{
                //    tmrAsama = 0;
                //    asama = 3;
                //}
                if (tmrAsama > 25 && yBaslangic[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "HOME";
                    dr["İslem"] = "ASAMA-3";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 3;
                }
            }
            else if (asama == 3)
            {
                modbusClient.WriteSingleRegister(0, 2);
                bool[] xGitti = modbusClient.ReadCoils(14, 1);
                tmrAsama++;
                //if (tmrAsama > 25 && xGitti[0])
                //{

                //    tmrAsama = 0;
                //    asama = 4;
                //    tmrHome.Stop();
                //}
                if (tmrAsama > 25 && xGitti[0])
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "HOME";
                    dr["İslem"] = "ASAMA-4";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 4;
                    tmrHome.Stop();
                }
            }
        }

        private void tmrDuzen_Tick(object sender, EventArgs e)
        {
            if (asama == 0)
            {
                if (currentSise == 0)
                {
                    modbusClient.WriteSingleRegister(0, Convert.ToInt16("1"));
                    //x ekseni 1 degerini altın                                                                       

                    bool[] xFlakonda = modbusClient.ReadCoils(14, 1);

                    tmrAsama++;
                    if (tmrAsama > 25 && xFlakonda[0] == true)
                    {
                        DataRow dr = table.NewRow();
                        dr["Method"] = "Duzen Sise-1" + " -> " + (currentCekim + 1).ToStr();
                        dr["İslem"] = "ASAMA-1";
                        table.Rows.Add(dr);
                        gridControl1.DataSource = table;
                        asama = 1;
                        tmrAsama = 0;
                    }
                }
                if (currentSise == 1)
                {
                    modbusClient.WriteSingleRegister(0, Convert.ToInt16("2"));
                    //x ekseni 1 degerini altına gitti

                    bool[] xFlakonda = modbusClient.ReadCoils(14, 1);

                    tmrAsama++;
                    if (tmrAsama > 25 && xFlakonda[0] == true)
                    {
                        DataRow dr = table.NewRow();
                        dr["Method"] = "Duzen Sise-2" + " -> " + (currentCekim + 1).ToStr();
                        dr["İslem"] = "ASAMA-1";
                        table.Rows.Add(dr);
                        gridControl1.DataSource = table;
                        asama = 1;
                        tmrAsama = 0;
                    }
                }
                if (currentSise == 2)
                {
                    modbusClient.WriteSingleRegister(0, Convert.ToInt16("3"));
                    //x ekseni 1 degerini altına gitti

                    bool[] xFlakonda = modbusClient.ReadCoils(14, 1);

                    tmrAsama++;
                    if (tmrAsama > 25 && xFlakonda[0] == true)
                    {
                        DataRow dr = table.NewRow();
                        dr["Method"] = "Duzen Sise-3" + " -> " + (currentCekim + 1).ToStr();
                        dr["İslem"] = "ASAMA-1";
                        table.Rows.Add(dr);
                        gridControl1.DataSource = table;
                        asama = 1;
                        tmrAsama = 0;
                    }
                }
                if (currentSise == 3)
                {
                    modbusClient.WriteSingleRegister(0, Convert.ToInt16("4"));
                    //x ekseni 1 degerini altına gitti

                    bool[] xFlakonda = modbusClient.ReadCoils(14, 1);

                    tmrAsama++;
                    if (tmrAsama > 25 && xFlakonda[0] == true)
                    {
                        DataRow dr = table.NewRow();
                        dr["Method"] = "Duzen Sise-4" + " -> " + (currentCekim + 1).ToStr();
                        dr["İslem"] = "ASAMA-1";
                        table.Rows.Add(dr);
                        gridControl1.DataSource = table;
                        asama = 1;
                        tmrAsama = 0;
                    }
                }


            }
            else if (asama == 1)
            {
                modbusClient.WriteSingleRegister(0, 16);
                bool[] zAzIndi = modbusClient.ReadCoils(30, 1);
                tmrAsama++;
                if (tmrAsama > 15 && zAzIndi[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Duzen Sise-" + (currentSise + 1).ToString() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-2";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 2;
                    tmrAsama = 0;
                }
            }
            else if (asama == 2)
            {
                modbusClient.WriteSingleRegister(0, 17);//z asagi iniyor.
                bool[] zAsagıda = modbusClient.ReadCoils(30, 1);
                tmrAsama++;
                if (tmrAsama > 15 && zAsagıda[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Duzen Sise-" + (currentSise + 1).ToString() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-3";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 3;
                    tmrAsama = 0;
                }
            }
            else if (asama == 3)
            {
                modbusClient.WriteSingleRegister(0, 18);//z asagi iniyor.
                bool[] zAsagıda = modbusClient.ReadCoils(30, 1);

                // ne kadar çekim yapacagı 
                tmrAsama++;
                if (tmrAsama > 15 && zAsagıda[0] == true)
                {
                    int injectorId = siseListesi[currentSise].InjektorId.ToInt();
                    Injectors injector = db.Injectors.FirstOrDefault(a => a.Id == injectorId);
                    if (uygulanacakDoz > injector.Capacity)
                    {
                        topValue = injector.TopValue.ToDbl();
                        botValue = injector.BotValue.ToDbl();
                        stepValue = (topValue - botValue) / 4; //  3x-2y=Adım   x=2k y=k  total=4k = Tum Aralık  
                        uygulanacakDoz = uygulanacakDoz - injector.Capacity;
                    }
                    else
                    {

                        topValue = injector.TopValue;
                        double perMl = ((topValue - botValue) / injector.Capacity).ToDbl(); // bir ml için motor hareket sayısı
                        botValue = topValue - (perMl * uygulanacakDoz.ToDbl());
                        stepValue = ((topValue - botValue) / 4).ToDbl();
                    }

                    DataRow dr = table.NewRow();
                    dr["Method"] = "Duzen Sise-" + (currentSise + 1).ToString() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-4";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 1;
                    tmrAsama = 1;
                    tmrDuzen.Stop();
                    tmrFlakomTarti.Start();
                    ilkOkumaFlakom = true;
                    // tmrCekim.Start();
                }
            }
        }


        private void tmrCekim_Tick(object sender, EventArgs e)
        {



            if (asama == 1)
            {

                modbusClient.WriteSingleRegister(13,/*bu kısım ayarlanacak--->*/ topValue.ToInt() - (2 * Math.Ceiling(stepValue)).ToInt()); // Örnek olarak topValue=10500 botValue=2700  stepValue aralarındaki farkın 4 e bolunmesi yani 1950

                modbusClient.WriteSingleRegister(11, 3000);// bu değerler 5 çekimden oluşuyor 3 kere çek 2 kere it olarak.
                modbusClient.WriteSingleCoil(6, true);//      ona göre sayıları almamız gerekiyor.
                bool[] yCekiyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 25 && yCekiyor[0] == true)
                {


                    DataRow dr = table.NewRow();
                    dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-1";
                    dr["Hareket_Noktası"] = (topValue.ToInt() - (2 * Math.Ceiling(stepValue)).ToInt()).ToString();
                    var a = (topValue.ToInt() - (2 * Math.Ceiling(stepValue)).ToInt());
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 2;
                    tmrAsama = 0;
                }

            }
            else if (asama == 2)
            {
                //modbusClient.WriteSingleRegister(13, 7800);//y itiyor
                modbusClient.WriteSingleRegister(13, topValue.ToInt() - (1 * Math.Ceiling(stepValue)).ToInt());//y itiyor

                modbusClient.WriteSingleRegister(11, 3000);
                modbusClient.WriteSingleCoil(6, true);
                bool[] yItiyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 25 && yItiyor[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1); dr["İslem"] = "ASAMA-2";
                    dr["Hareket_Noktası"] = (topValue.ToInt() - (1 * Math.Ceiling(stepValue)).ToInt()).ToString();

                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 3;
                }

            }
            else if (asama == 3)
            {
                //modbusClient.WriteSingleRegister(13, 4400);//y çekiyor.
                modbusClient.WriteSingleRegister(13, topValue.ToInt() - (3 * Math.Ceiling(stepValue)).ToInt()); top noktada 3k uzaklıga gıdıyor demek


                modbusClient.WriteSingleRegister(11, 3000);
                modbusClient.WriteSingleCoil(6, true);
                bool[] yCekiyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 25 && yCekiyor[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1); dr["İslem"] = "ASAMA-3";
                    dr["Hareket_Noktası"] = (topValue.ToInt() - (3 * Math.Ceiling(stepValue)).ToInt()).ToString();

                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 4;
                    tmrAsama = 0;
                }
            }
            else if (asama == 4)
            {
                //modbusClient.WriteSingleRegister(13, 6100);//y itiyor
                modbusClient.WriteSingleRegister(13, topValue.ToInt() - (2 * Math.Ceiling(stepValue)).ToInt());// top noktadan 2 k uzaklıga dogru itiyor

                modbusClient.WriteSingleRegister(11, 3000);
                modbusClient.WriteSingleCoil(6, true);
                bool[] yItiyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 25 && yItiyor[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["Hareket_Noktası"] = (topValue.ToInt() - (2 * Math.Ceiling(stepValue)).ToInt()).ToString();


                    dr["İslem"] = "ASAMA-4";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 5;
                }

            }
            else if (asama == 5)
            {
                //modbusClient.WriteSingleRegister(13, 2700);//y cekiyor
                modbusClient.WriteSingleRegister(13, topValue.ToInt() - (4 * Math.Ceiling(stepValue)).ToInt()); // son olarak bottom noktasına geliyor

                modbusClient.WriteSingleRegister(11, 3000);
                modbusClient.WriteSingleCoil(6, true);
                bool[] yItiyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 25 && yItiyor[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-5";
                    dr["Hareket_Noktası"] = (topValue.ToInt() - (4 * Math.Ceiling(stepValue)).ToInt()).ToString();

                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 6;
                }

            }
            else if (asama == 6)
            {
                DataRow dr = table.NewRow();
                dr["Method"] = "Cekim Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                dr["İslem"] = "ASAMA-6";

                table.Rows.Add(dr);
                gridControl1.DataSource = table;

                asama = 0;
                tmrCekim.Stop();
                ilkOkumaFlakom = false;
                tmrFlakomTarti.Start();
                tmrAsama = 0;
                //tmrBasma.Start();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tmrAsama = 0;
            asama = 0;
            tmrDuzen.Start();
        }

        private void tmrBasma_Tick(object sender, EventArgs e)
        {
            if (asama == 0)
            {
                modbusClient.WriteSingleRegister(0, 16);//z yukarı çıkıyor.
                bool[] zYukarda = modbusClient.ReadCoils(30, 1);
                tmrAsama++;
                if (tmrAsama > 15 && zYukarda[0] == true)
                {

                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-0";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 1;
                    tmrAsama = 0;
                }
            }
            else if (asama == 1)
            {
                modbusClient.WriteSingleRegister(0, 2);
                bool[] xOrta = modbusClient.ReadCoils(14, 1);
                tmrAsama++;
                if (tmrAsama > 15 && xOrta[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-1";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;

                    serialPort1.Write("e");//başı eğdiriyoruz.

                    DataRow drs = table.NewRow();
                    drs["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + " Basını Egdiriyoruz";
                    drs["İslem"] = "ASAMA-1";
                    table.Rows.Add(drs);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 2;
                }
            }
            else if (asama == 2)
            {
                // Burada 9.5 sn bekliyor 95 degeri buna denk geliyor 

                tmrAsama++;
                if (tmrAsama > 95)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-2";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 3;
                    tmrAsama = 0;
                }
            }
            else if (asama == 3)
            {
                modbusClient.WriteSingleRegister(0, 12);//x i seruma basma konumuna gönderiyoruz. ben 14 diye öngördüm.
                bool[] xBasmada = modbusClient.ReadCoils(14, 1);
                tmrAsama++;
                if (tmrAsama > 40 && xBasmada[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-3";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 4;
                    tmrAsama = 0;
                }
            }
            else if (asama == 4)
            {
                modbusClient.WriteSingleRegister(0, 13);//x i seruma basma konumuna gönderiyoruz. ben 14 diye öngördüm.
                bool[] xBasmada = modbusClient.ReadCoils(14, 1);
                tmrAsama++;
                if (tmrAsama > 20 && xBasmada[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-4";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 5;
                    tmrAsama = 0;
                }
            }
            else if (asama == 5)
            {
                modbusClient.WriteSingleRegister(13, 10200);//y itime başlıyor.
                modbusClient.WriteSingleRegister(13, Math.Ceiling(topValue).ToInt());//y itime başlıyor.

                modbusClient.WriteSingleRegister(11, 3000);//y nin hızı.
                modbusClient.WriteSingleCoil(6, true);
                bool[] yItıyor = modbusClient.ReadCoils(4, 1);
                tmrAsama++;
                if (tmrAsama > 55 && yItıyor[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-5";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrAsama = 0;
                    asama = 6;
                }
            }
            else if (asama == 6)
            {
                modbusClient.WriteSingleRegister(0, 2);//x i ortaya yolluyor.
                bool[] xOrta = modbusClient.ReadCoils(14, 1);
                tmrAsama++;
                if (tmrAsama > 25 && xOrta[0] == true)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-6";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 7;
                    tmrAsama = 0;
                }
            }
            else if (asama == 7)
            {
                DataRow dr = table.NewRow();
                dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                dr["İslem"] = "ASAMA-7";
                table.Rows.Add(dr);
                gridControl1.DataSource = table;


                serialPort1.Write("m");

                DataRow drs = table.NewRow();
                drs["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + " Kalkıyor ... ";
                drs["İslem"] = "ASAMA-7";
                table.Rows.Add(drs);
                gridControl1.DataSource = table;

                asama = 8;
            }
            else if (asama == 8)
            {
                // 9.5 sn burada bekliyor ... 
                tmrAsama++;
                if (tmrAsama > 95)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-8";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 9;
                    tmrAsama = 0;
                }
            }
            else if (asama == 9)
            {

                if (currentSise < siseListesi.Count + 1)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "BASMA Sise-" + (currentSise + 1).ToStr() + "-->" + (currentCekim + 1);
                    dr["İslem"] = "ASAMA-9";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    asama = 0;

                    currentCekim++;


                    if (siseListesi.Count > currentSise + 1)
                    {
                        if (currentCekim == siseListesi[currentSise].TripCounter)
                        {
                            currentCekim = 0;
                            currentSise++;

                        }

                        tmrBasma.Stop();
                        tmrDuzen.Start();
                    }
                    else
                    {
                        DataRow drs = table.NewRow();
                        drs["Method"] = "Finish";
                        drs["İslem"] = "Bitti";
                        table.Rows.Add(drs);
                        gridControl1.DataSource = table;
                        tmrBasma.Stop();
                        MessageBox.Show("İşlem Tamamlanmıştır.");
                    }


                }
                else if (currentSise == siseListesi.Count + 1)
                {
                    DataRow dr = table.NewRow();
                    dr["Method"] = "Finish";
                    dr["İslem"] = "Bitti";
                    table.Rows.Add(dr);
                    gridControl1.DataSource = table;
                    tmrBasma.Stop();
                    MessageBox.Show("İşlem Tamamlanmıştır.");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tmrFlakomTarti_Tick(object sender, EventArgs e)
        {
            if (ilkOkumaFlakom)
            {
                if (tmrAsama > 5 && tmrAsama < 7)
                {
                    //serialPort1.Write("ta");
                    //var ilkDeger = serialPort1.ReadLine();
                    //ilkOkumaFlakomDeger = ilkDeger.ToDbl();
                    DataRow dr = flakomTable.NewRow();
                    dr["Okuma"] = "İlk Okuma";
                    dr["Deger"] = "110";
                    ilkOkumaFlakomDeger = 110;
                    flakomTable.Rows.Add(dr);
                    GControlFlakomTarti.DataSource = flakomTable;
                }

                if (tmrAsama > 25)
                {
                    asama = 1;
                    tmrAsama = 1;
                    tmrFlakomTarti.Stop();
                    tmrCekim.Start();
                }
            }
            else
            {





                if (tmrAsama > 5 && tmrAsama < 7)
                {
                    //serialPort1.Write("ta");
                    //var sonDeger = serialPort1.ReadLine();
                    //sonOkumaFlakomDeger = sonDeger.ToDbl();

                    var sonDeger = "61";
                    sonOkumaFlakomDeger = sonDeger.ToDbl();
                    DataRow dr = flakomTable.NewRow();
                    dr["Okuma"] = "SonOkuma Okuma";
                    dr["Deger"] = sonDeger;
                    flakomTable.Rows.Add(dr);
                    GControlFlakomTarti.DataSource = flakomTable;
                }


                if (tmrAsama > 25)
                {
                    int injectorId = siseListesi[currentSise].InjektorId.ToInt();
                    Injectors injector = db.Injectors.FirstOrDefault(a => a.Id == injectorId);
                    double olcumYapılacakMiktar = 0;


                    // Buradaki amaç son şiseye geldiginde olcumu 50 ml gore degilde çekmesi gereken kadar degerler isleme devam edilmesi
                    if (uygulanacakDoz > injector.Capacity)
                    {
                        olcumYapılacakMiktar = injector.Capacity;
                    }
                    else
                    {

                        olcumYapılacakMiktar = uygulanacakDoz;
                    }

                    var katsayi = ((olcumYapılacakMiktar / 100) * 3);
                    var olcumSonrasi = (olcumYapılacakMiktar - (ilkOkumaFlakomDeger - sonOkumaFlakomDeger));

                    if (katsayi > olcumSonrasi)
                    {

                        asama = 0;
                        tmrFlakomTarti.Stop();
                        tmrAsama = 0;
                        tmrBasma.Start();
                        ilkOkumaFlakom = true;

                    }
                    else
                    {
                        DataRow drs = table.NewRow();
                        drs["Method"] = "Finish";
                        drs["İslem"] = "Bitti";
                        table.Rows.Add(drs);
                        gridControl1.DataSource = table;

                        tmrFlakomTarti.Stop();
                        // yeniden çekim metodu
                        MessageBox.Show("Yeniden Çekim");



                    }
                }

            }

            tmrAsama++;

        }
    }


}


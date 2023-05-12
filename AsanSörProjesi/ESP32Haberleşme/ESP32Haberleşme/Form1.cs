using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ESP32Haberleşme
{
    public partial class Form1 : Form
    {
        private string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            string[] ports = SerialPort.GetPortNames(); //port isimlerini ports string dizisine ata
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port); //ports dizisi içindeki port isimlerini port adında başka bir değişkene ata ve combobox1'a ata
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //data received eventi oluşturuldu
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            //progressBar1.Value = Convert.ToInt32(data);
            textBox1.Text = data; //textbox1 ın textine datayı bas
            label2.Text = "Işık Şiddeti: " + data;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text; //port ismini combobox1'in textine yazdır
                serialPort1.BaudRate = 9600; //baudrate 9600 olarak ayarla
                serialPort1.Open(); //seri portu aç
                btnBaglan.Enabled = false; //bağlan butonunu inaktif et
                btnDurdur.Enabled = true; //durdur butonunu aktif et
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata"); //porta düzgün bir şekilde bağlanılamazsa "hata" diye bir uyarı gönder
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close(); //seri portu kapat
                btnBaglan.Enabled = true; //bağlan butounu aktif et
                btnDurdur.Enabled = false; //durdur butonunu inaktif et
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata"); //düzgün bir şekilde bağlantı kesilmezse "hata" diye bir uyarı gönder
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); //formu kapattığımda seriport açık ise portu kapat
            }
        }

        private void btnSes_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a" + ","); //karta seri port üzerinden 1 gönderilecek ve böylece buzzerın ötmesi sağlanıcak
            lblBuzzer.Text = "Buzzerda ses var";
            btnSus.Enabled = true;
            btnSes.Enabled = false;
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b" + ",");//karta seri port üzerinden 0 gönderilecek ve böylece buzzerın susması sağlanıcak
            lblBuzzer.Text = "Buzzer sustu";
            btnSes.Enabled = true;
            btnSus.Enabled = false;
        }


        ///////////////////Fan Ayarları///////////////////////////////////////////////
        private void Dondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("y" + ",");  //Butona basınca fanı yavaş hızda döndürücek
        }

        private void ortaDondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o" + ",");  //Butona basınca fanı orta hızda döndürücek
        }

        private void hizliDondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h" + ",");   //Butona basınca fanı hızlı olarak döndürücek
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d" + ",");   //Butona basınca fanı durdurucak
        }

        private void RevYavasDondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e" + ","); //Butona basınca fanı terse yavaş hızda döndürücek
        }

        private void revOrtaDondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f" + ",");   //Butona basınca fanı terse orta hızda döndürücek
        }

        private void revHizliDondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g" + ",");   //Butona basınca fanı terse hızlı olarak döndürücek
        }

        ////////////////////////////Servo Motor Ayarları//////////////////////////////////////////////
        private void servoBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s" + ",");   //Butona basınca servoyu ileri döndürür
        }

        private void servoGeriBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("r" + ",");   //Butona basınca servoyu eski konumuna döndürür
        }

        private void servoBtn_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("s" + ",");
            serialPort1.Write("s" + ",");


        }
        private void servoBtn_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("s" + ",");
            serialPort1.Write("s" + ",");
        }

        private void servoGeriBtn_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("r" + ",");
            serialPort1.Write("r" + ",");
        }

        private void servoGeriBtn_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("r" + ",");
            serialPort1.Write("r" + ",");
        }

        
       
    }
}

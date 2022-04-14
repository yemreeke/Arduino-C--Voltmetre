using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace VoltMetre{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            cboxPort.DataSource = SerialPort.GetPortNames();
            int[] BoudRates = {115200};
            cboxBaudRate.DataSource = BoudRates;
        }

        private void btnBaglan_Click(object sender, EventArgs e){
            try{
                serialPort1.PortName = cboxPort.Text;
                serialPort1.BaudRate = Int32.Parse(cboxBaudRate.Text);
                serialPort1.ReadTimeout = 300; // okuma zaman aşım
                serialPort1.Open();
                if (serialPort1.IsOpen){
                    //Arduinoya X verisini Yolluyoruz.
                    //Arduino Bize Bir metin yolluyor.
                    //Metin doğruysa bağlantı başarılı oluyor.
                    serialPort1.Write("X"); 
                    Thread.Sleep(250);
                    string Sifre = serialPort1.ReadLine();
                    Sifre = Sifre.Trim();
                    if(Sifre== "yemreeke"){
                        btnBaglan.Enabled = false;
                        btnBaglantiKes.Enabled = true;
                        btnTestBaslat.Enabled = true;
                        cboxBaudRate.Enabled = false;
                        cboxPort.Enabled = false;
                        MessageBox.Show("Bağlantı Başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Şifre Yanlış!");
                        serialPort1.Close();
                    }
                }
            }
            catch (Exception){
                MessageBox.Show("Bağlantı Hatası!!!");
                serialPort1.Close();
            }
        }
        private void btnBaglantiKes_Click(object sender, EventArgs e){
            //Tüm baytları okuyoruz ve tekrar bağlanırken gereksiz veri yollamasın
            string gereksizVeri = serialPort1.ReadExisting();
            timerVeriOku.Enabled = false;
            serialPort1.Close();
            MessageBox.Show("Bağlantı Kesildi!");
            btnBaglantiKes.Enabled = false;
            btnBaglan.Enabled = true;
            btnTestBaslat.Enabled = false;
            btnTestDurdur.Enabled = false;
            cboxBaudRate.Enabled = true;
            cboxPort.Enabled = true;
        }

        private void btnTestBaslat_Click(object sender, EventArgs e){
            //Testi başlatmak için A verisini yolluyoruz.
            // Arduino a verisi geldiyse bize ölçtüğü voltajları yolluyor.
            serialPort1.Write("A");
            btnTestBaslat.Enabled = false;
            btnTestDurdur.Enabled = true;
            timerVeriOku.Enabled = true;
            btnBaglantiKes.Enabled = false;
        }

        private void btnTestDurdur_Click(object sender, EventArgs e){
            serialPort1.Write("K");
            tboxVoltaj.Text = "0.000";
            tboxVoltaj.BackColor = Color.White;
            btnTestBaslat.Enabled = true;
            btnTestDurdur.Enabled = false;
            timerVeriOku.Enabled = false;
            btnBaglantiKes.Enabled = true;
        }
        private void timerVeriOku_Tick(object sender, EventArgs e){
            timerVeriOku.Stop();
            try
            {
                string veri = serialPort1.ReadLine();
                veri = veri.Trim();
                tboxVoltaj.Text = veri;
                double voltaj = double.Parse(veri.Replace(".",",")); // double a çevirmek için string 15,5 şeklinde olmalıdır
                // 15.5 olduğu için . yi replace ile , yapıp voltaj değişkenine atıyoruz.
                if(voltaj <= 4.2 && voltaj > 3.8){ //Voltaj 3.8 ile 4.2 arasında ise
                    tboxVoltaj.BackColor = Color.Green;
                }
                else if(voltaj<=3.8 && voltaj > 3.4){ // Voltaj 3.4 ile 3.8 arasında ise
                    tboxVoltaj.BackColor = Color.Yellow;
                }
                else if (voltaj <= 3.4 && voltaj > 3.0){ // Voltaj 3.4 ile 3.8 arasında ise
                    tboxVoltaj.BackColor = Color.Red;
                }
                else{
                    tboxVoltaj.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                throw;
            }
            timerVeriOku.Start();
        }
    }
}


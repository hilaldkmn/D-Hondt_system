using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milletvekili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oyButton_Click(object sender, EventArgs e) //Aldığı oyların yüzdesini bulur.
        {
            aOranTextBox.Text = ((100 * Convert.ToDouble(aTextBox.Text)) / Convert.ToDouble(nufusTextBox.Text)).ToString();
            bOranTextBox.Text = ((100 * Convert.ToDouble(bTextBox.Text)) / Convert.ToDouble(nufusTextBox.Text)).ToString();
            cOranTextBox.Text = ((100 * Convert.ToDouble(cTextBox.Text)) / Convert.ToDouble(nufusTextBox.Text)).ToString();
        }

        private void ilComboBox_SelectedIndexChanged(object sender, EventArgs e) //İlleri seçtiğinde textbox'a nufusunu getirir.
        {
            if(ilComboBox.SelectedItem.ToString() == "Kırklareli")
            {
                nufusTextBox.Text = "300000";
            }else if (ilComboBox.SelectedItem.ToString() == "Kocaeli")
            {
                nufusTextBox.Text = "600000";
            }else if(ilComboBox.SelectedItem.ToString() == "İstanbul")
            {
                nufusTextBox.Text = "1000000";
            }else if(ilComboBox.SelectedItem.ToString() == "Edirne")
            {
                nufusTextBox.Text = "400000";
            }else if (ilComboBox.SelectedItem.ToString() == "Antalya")
            {
                nufusTextBox.Text = "500000";
            }

            partiBilgileleri.Enabled = true;
            sayi.Enabled = true;
            istatistik.Enabled = true;
        }

        private void sayiButton_Click(object sender, EventArgs e) // Partilerin millet vekillerini bulur.
        {
            int A, B, C, G_A, G_B, G_C, D; 
            int AVekilSayısı=0, BVekilSayısı=0, CVekilSayısı=0;
            int geciciA=2, geciciB=2, geciciC=2; //Bölünme oranları ilk önce ikiye bölünerek başlayacağı için 2 değeri atadık. 
           

            A = Convert.ToInt32(aTextBox.Text); //A partisine her millet vekili artığında en başta ki bölünen oy sayısı.
            B = Convert.ToInt32(bTextBox.Text); //B partisine her millet vekili artığında en başta ki bölünen oy sayısı.
            C = Convert.ToInt32(cTextBox.Text); //C partisine her millet vekili artığında en başta ki bölünen oy sayısı.
            D = Convert.ToInt32(vekilTextBox.Text); //Toplamdaki millet vekili sayısı
            G_A = A; //G_A = A partisi bölündükten sonraki yeni değer alan geçici A partisi oy sayısı.
            G_B = B; //G_B = B partisi bölündükten sonraki yeni değer alan geçici A partisi oy sayısı.
            G_C = C; //G_C = C partisi bölündükten sonraki yeni değer alan geçici A partisi oy sayısı.

            for (int i = 0; i < D; i++) //Millet vekili sayısı kadar döndür
            {
              if (G_B <= G_A && G_C <= G_A) { //A partisinin oyu yüksekse girilecek koşul

                    AVekilSayısı = AVekilSayısı + 1; //millet vekili sayısı artırımı
                    G_A = A / geciciA++;  //Millet vekili sayısı artıktan sonra ,
                                          //asıl oy oranın aritmetik olarak 1 artan sayılarara bölünmesi 
                                          //ve karşılaştırılacak olan geçici oy sayısına atanması
                        
                    
                }
              else if (G_A <= G_B && G_C <= G_B)
                {  //B partisinin oyu yüksekse girilecek koşul
                    BVekilSayısı = BVekilSayısı + 1; //millet vekili sayısı artırımı
                    G_B = B / geciciB++;  //Millet vekili sayısı artıktan sonra ,
                                          //asıl oy oranın aritmetik olarak 1 artan sayılarara bölünmesi 
                                          //ve karşılaştırılacak olan geçici oy sayısına atanması


                }
                else if (G_B <= G_C && G_A <= G_C)
                { //C partisinin oyu yüksekse girilecek koşul
                    CVekilSayısı = CVekilSayısı + 1; //millet vekili sayısı artırımı
                    G_C = C / geciciC++;  //Millet vekili sayısı artıktan sonra ,
                                          //asıl oy oranın aritmetik olarak 1 artan sayılarara bölünmesi 
                                          //ve karşılaştırılacak olan geçici oy sayısına atanması
                }
            }
            
            aSayiTextBox.Text = Convert.ToString(AVekilSayısı);
            bSayiTextBox.Text = Convert.ToString(BVekilSayısı);
            cSayiTextBox.Text = Convert.ToString(CVekilSayısı);

        }
    }
}

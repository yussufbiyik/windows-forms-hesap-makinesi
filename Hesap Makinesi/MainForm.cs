/*
 * Created by SharpDevelop.
 * User: Yusuf Bıyık
 * Github: @yussufbiyik
 * yussufbiyik.github.io
 * Date: 3.10.2024
 * Time: 19:16
 * Bunu yapmanın daha kolay bi yolu kesin vardı.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		List<char> kullanilanOperatorler = new List<char>();
		List<char> verilenRakamlar = new List<char>();
		// Verilen rakamları sonradan sayıya çevirmek için bir List tanımla
		List<double> verilenSayilar = new List<double>();
		double sonuc = 0;
		// Çağırıldığı sırada listede bulunan rakamları sayıya çevirip verilenSayilar listesine ekle	
		void verilenSayiyiListeyeEkle() {
			// Önceki işlem bitmiş, yeni işleme geçilmiş olunca rakamlar listesi temizlenir
			// bu nedenle yeni bir operatör gelince rakamları sayıya çevirmenin gereği yok
			if(verilenRakamlar.Count == 0) {return;}
			// Rakamları string oldukları için Join ile yanyana getir ve Convert ile Double'a çevir
			verilenSayilar.Add(Convert.ToDouble(String.Join("", verilenRakamlar.ToArray())));
			/* Örn:
			* "5","2","3" rakamlarını içeren verilenRakamlar dizisini Join ile
			* "523" haline getirip Convert ile
			* 523 sayısına çevirir.
		 	*/
			// Rakamlar listesini temizle
			verilenRakamlar.Clear();
		}
		void hesapMakinesiniTemizle(){
			verilenSayilar.Clear();
			verilenRakamlar.Clear();
			kullanilanOperatorler.Clear();
		}
		void sonucHesapla(){
			// Bir işlem verilmemişse durumu konsola yaz ve geri dön, çalışma
			if(resultLabel.Text.Length<0) {MessageBox.Show("İşlem yazılmadı");return;};
           	// Peşine operatör gelmediğinden şu ana kadar hesaplanmamış son sayıyı da hesapla
           	verilenSayiyiListeyeEkle();
			// İlk sayıyı sonuç değişkenine ata
			sonuc = verilenSayilar.First();
           	// Hesaplanan indexleri kaydetmek için bir liste oluştur
           	List<int> indexler = new List<int>();
			// Verilen sayıların her birini operatörü göz önünde bulundurup uygun işlemi yap
			for(int i = 0; i < kullanilanOperatorler.Count;i++) {
                double sonrakiSayi = verilenSayilar[i + 1]; // Sonraki sayıyı al
                char kullanilanOperator = kullanilanOperatorler[i];
               	// O sırada kullanılan operatöre göre hesap yap
               	// Switch Case yapısı bu durumda if else'e kıyasla daha okunaklı ve iyi
               	switch (kullanilanOperator) {
               		case '+':
						sonuc += sonrakiSayi;
               			break;
               		case '-':
               			sonuc -= sonrakiSayi;
               			break;
               		case '*':
               			sonuc *= sonrakiSayi;
               			break;
               		case '/':
               			// 0'a bölünmeye karşı kontrol yap
               			if(sonrakiSayi == 0) {
               				MessageBox.Show("Sıfıra bölme hatası!");
               				hesapMakinesiniTemizle();
               				return;
               			}
               			sonuc /= sonrakiSayi;
               			break;
               		case '%':
               			sonuc %= sonrakiSayi;
               			break;
               	}
			}
		}
		
		// ARAYÜZ KODLARI
		
		// Rakam ekleme butonlarını tanımla
		void Button1Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('1');
			resultLabel.Text += "1";
		}
		void Button2Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('2');
			resultLabel.Text += "2";
		}
		void Button3Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('3');
			resultLabel.Text += "3";
		}
		void Button4Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('4');
			resultLabel.Text += "4";
		}
		void Button5Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('5');
			resultLabel.Text += "5";
		}
		void Button6Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('6');
			resultLabel.Text += "6";
		}
		void Button7Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('7');
			resultLabel.Text += "7";
		}
		void Button8Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('8');
			resultLabel.Text += "8";
		}
		void Button9Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('9');
			resultLabel.Text += "9";
		}
		void Button10Click(object sender, EventArgs e)
		{
			verilenRakamlar.Add('0');
			resultLabel.Text += "0";
		}
		
		// İşlem operatörlerini tanımla
		void SumButtonClick(object sender, EventArgs e)
		{
			resultLabel.Text += "+";
			kullanilanOperatorler.Add('+');
			verilenSayiyiListeyeEkle();
		}
		void SubtractButtonClick(object sender, EventArgs e)
		{
			resultLabel.Text += "-";
			kullanilanOperatorler.Add('-');
			verilenSayiyiListeyeEkle();
		}
		void MultiplyButtonClick(object sender, EventArgs e)
		{
			resultLabel.Text += "*";
			kullanilanOperatorler.Add('*');
			verilenSayiyiListeyeEkle();
		}
		void DivideButtonClick(object sender, EventArgs e)
		{
			resultLabel.Text += "/";
			kullanilanOperatorler.Add('/');
			verilenSayiyiListeyeEkle();
		}
		void ModButtonClick(object sender, EventArgs e)
		{
			resultLabel.Text += "%";
			kullanilanOperatorler.Add('%');
			verilenSayiyiListeyeEkle();
		}
		
		// Temizleme ve tamamen temizleme butonlarını tanımla
		void ClearButtonClick(object sender, EventArgs e)
		{
			// Son rakamı hem ekrandan hem de listeden sil
			verilenRakamlar.RemoveAt(verilenRakamlar.Count-1);
			resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.Length-1,1);
		}
		void AllClearButtonClick(object sender, EventArgs e)
		{
			// Sayı ve rakam geçmişini temizle
			verilenSayilar.Clear();
			verilenRakamlar.Clear();
			// Ekranda görünen sayıları temizle
			resultLabel.Text = "";
		}
		
		// Hesaplama butonunu tanımla
		void CalculateButtonClick(object sender, EventArgs e)
		{
			sonucHesapla();
			hesapMakinesiniTemizle();
			// Sonucu verilen sayılar listesine geri ekle
			verilenSayilar.Add(sonuc);
			// Sonucu ekrana yazdır
           	resultLabel.Text = Convert.ToString(sonuc);
		}
	}
}

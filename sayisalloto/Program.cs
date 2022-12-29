int[] sayilar=new int[6];
int[] kasaSayilar=new int[6];
int tahmin= 0;

Console.WriteLine("lütfen 6 adet sayı giriniz");
Random rnd =new Random();

for (int i = 0; i < 6; i++)
{
    kasaSayilar[i]= rnd.Next(1,60);
    Console.WriteLine("{0}. sayiyi giriniz :",(i+1));
    sayilar[i]=int.Parse(Console.ReadLine()!);
}

foreach (var sayi in sayilar)
{
    foreach (var kasaSayi in kasaSayilar)
    {
        tahmin = sayi == kasaSayi ? tahmin++ : tahmin;
    } 
}
Console.WriteLine("{0} adet doğru tahminde bulundunuz", tahmin);
Console.WriteLine("Random sayilar:");
for (int i = 0; i < kasaSayilar.Length; i++)
{
 Console.WriteLine("{0}",kasaSayilar[i]);   
}
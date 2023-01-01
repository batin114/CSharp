﻿
using Yeni_klasör__2_.Models;

Atp11Context db = new Atp11Context();
List<Todo> todoList = new List<Todo>();
int _id;
string _title;
string _isComplated;
string select;

while (true)
{
    Console.WriteLine("Yapmak istediğiniz işlemi seçin: \n[0] Çıkış \n[1] Listele \n[2] Ekle \n[3] Düzenle \n[4] Sil");
    select = Console.ReadLine()!;
    switch (select)
    {
        case "0":
            cikis();
            break;
        case "1":
            listele(todoList);
            break;
        case "2":
            ekle();
            break;
        case "3":
            guncelle();
            break;
        case "4":
            sil();
            break;
        default:
            Console.WriteLine("0-4 arasında bir değer giriniz");
            break;
    }
}
void cikis()
{
    Console.WriteLine("Çıkmak istediğinize emin misiniz? E veya H deyin.");
    string onExit = Console.ReadLine()!;
    if (onExit.ToLower() == "e")
    {
        Console.WriteLine("Güle güle...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Çıkış işlemi iptal edildi.");
    }
}
void ekle()
{
    Console.Write("Lütfen Başlık Giriniz :");
    _title = Console.ReadLine()!;
    Todo p = new Todo();
    p.Title = _title;
    p.Iscomplated = 0;
    db.Add(p);
    db.SaveChanges();
    Console.WriteLine("Kaydınız Başarıyla Eklendi");
}

void listele(List<Todo> todoList)
{

    var Todos = db.Todos.ToList();
    Console.WriteLine("ID\tBaşlık\t\tDurum");

    foreach (var item in Todos)
    {
        if (item.Iscomplated == 0)
        {
            Console.WriteLine($"{item.Id}\t{item.Title}\t\tfalse");
        }
        else
        {
            Console.WriteLine($"{item.Id}\t{item.Title}\t\ttrue");
        }
    }
}

void guncelle()
{
    Console.Write("Lütfen Değiştirmek İstediğiniz İd Numarasını Giriniz:");
    _id = int.Parse(Console.ReadLine()!);
    Todo t = db.Todos.FirstOrDefault(x => x.Id == _id)!;
    System.Console.Write("Yeni Başlık Giriniz:");
    _title = Console.ReadLine()!;
    System.Console.Write("Görev Tamamlandı Mı? (E veya H Kullanınız.)");
    _isComplated = Console.ReadLine()!.ToUpper();
    if (t != null)
    {
        if (_isComplated == "E")
        {
            t.Iscomplated = 1;
        }
        else if (_isComplated == "H")
        {
            t.Iscomplated = 0;
        }
        t.Title = _title;
        System.Console.WriteLine("Kaydınız Başarıyla Değiştirildi!");
    }
    else
    {
        System.Console.WriteLine("id bulunamadı");
    }
    db.SaveChanges();
}



void sil()
{
    Console.Write("Lütfen Silmek İstediğiniz İd Numarasını Giriniz:");
    _id = int.Parse(Console.ReadLine()!);
    Todo t = db.Todos.FirstOrDefault(x => x.Id == _id)!;
    db.Remove(t);
    Console.Write("Başarıyla Silinmiştir.");
    db.SaveChanges();
}
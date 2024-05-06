using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia(nome: "nokia", numero: "123456", modelo: "Modelo 2", imei: "232424254", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(nome: "Iphone 14 pro", numero: "9425", modelo: "Iphone 14 pro", imei: "2048298492", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");
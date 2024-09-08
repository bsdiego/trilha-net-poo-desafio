using DesafioPOO.Models;

// Implementado

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4444-2222", modelo: "Modelo 1", ime: "111.222.777.888", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("GTA IV");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "8888-4444", modelo: "Modelo 2", ime: "888.222.111.444", memoria: 254);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
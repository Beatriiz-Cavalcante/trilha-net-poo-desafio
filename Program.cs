using DesafioPOO.Models;


//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone ");
Smartphone Nokia = new Nokia(numero: "81-986849198", modelo: "Nokia Tijolão", imei: "12345678994", memoria: "180gb");
Nokia.Ligar();
Nokia.InstalarAplicativo("Linkedin");
Nokia.ReceberLigacao();


Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "81-82722141", modelo: "Iphone 5c", imei: "49987654321", memoria: "360gb");
iphone.Ligar();
iphone.InstalarAplicativo("Netflix");
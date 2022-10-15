using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Testes Realizados

Nokia smartphone1 = new Nokia(numero: "919711111", modelo: "Nokia X20", imei:"123456789012345", memoria: 128);
smartphone1.Ligar();
smartphone1.InstalarAplicativo("WhatsApp");

System.Console.WriteLine();

Iphone iphone1 = new Iphone(numero: "123456789", modelo: "iPhone 13", imei: "123456789009876", 256);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("PicPay");
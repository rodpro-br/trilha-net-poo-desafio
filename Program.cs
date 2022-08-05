using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("11999999999", "3370", "1234567890", 20);
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();

Iphone iphone = new Iphone("12999999999", "13 Pro Max", "9876543210", 128);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
iphone.Ligar();
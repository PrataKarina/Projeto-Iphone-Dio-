using DesafioPOO.Models;

Nokia celular1 = new Nokia("911110000","nokia 2", "0000123456", 12);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("newApp");

Iphone phone1 = new Iphone("900001111","iphone 11", "000078910", 24);
phone1.Ligar();
phone1.ReceberLigacao();
phone1.InstalarAplicativo("newApp");
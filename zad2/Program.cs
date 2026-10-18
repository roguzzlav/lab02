int exp = 40;
int gold = 50;
int trainNum = 1;

Console.WriteLine("Stan początkowy: \n Doświadczenie: "+exp+"\n Zloto: "+gold+"\n Numer treningu: "+trainNum);

exp+=25;
exp*=2;
gold-=8;
gold+=15;
trainNum++;

Console.WriteLine("Stan końcowy: \n Doświadczenie: "+exp+"\n Zloto: "+gold+"\n Numer treningu: "+trainNum);
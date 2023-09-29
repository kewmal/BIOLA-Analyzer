
using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
namespace Projektkoncowymalickibiol{
	//klasa glowna
public class OrganizmZywy{
protected string typ;
protected string nazwa;
public OrganizmZywy(string typ_,string nazwa_){
this.typ=typ_;
this.nazwa=nazwa_;
}
public virtual string ZobaczNazwe(){
return nazwa;
		}


public virtual void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("_____________________________");
		}
		}
public class Ptak:OrganizmZywy{
public string gatunek;
public string rodzina;
public int wysokosc=0;
	
public Ptak(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_):base(typ_,nazwa_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}
public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten ptak jest z gatunku {1}",gatunek);		}
	}
	
public class Gad:OrganizmZywy{
public string gatunek;
public string rodzina;
public int wysokosc=0;
	
public Gad(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_):base(typ_,nazwa_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}

public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten gad jest z gatunku {1}",gatunek);		}
	}

public class Ssak:OrganizmZywy{
public string gatunek;
public string rodzina;
public int wysokosc=0;
	
public Ssak(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_):base(typ_,nazwa_) {
this.typ=typ_;
this.nazwa=nazwa_;
gatunek=gatunek_;
rodzina=rodzina_;
wysokosc=wysokosc_;
		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten ssak jest z gatunku {1}",gatunek);		}
	}

public class Bakteria:OrganizmZywy{
public string gatunek;
public string rodzina;
public int wysokosc=0;
	
public Bakteria(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_):base(typ_,nazwa_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}

public virtual void WyswietlGatunek(){
			Console.WriteLine("Ta bakteria jest z gatunku {1}",gatunek);		}
	}

public class Czlowiek:Ssak{
public string imie;
public string nazwisko;
public int ilemalat=0;
	
public Czlowiek(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string imie_,string nazwisko_,int ilemalat_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.imie=imie_;
this.nazwisko=nazwisko_;
this.ilemalat=ilemalat_;

		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Imie: {0}",imie);
Console.WriteLine("Nazwisko: {0}",nazwisko);
Console.WriteLine("Wiek: {0}",ilemalat);

Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten czlowiek jest z gatunku {1}",gatunek);		}
	}

public class CzlowiekDNA:Czlowiek{
private string dna;
private int jakdlugifragment=0;	
public CzlowiekDNA(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string imie_,string nazwisko_,int ilemalat_,string dna_,int jakdlugifragment_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_,imie_, nazwisko_, ilemalat_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.imie=imie_;
this.nazwisko=nazwisko_;
this.ilemalat=ilemalat_;
this.dna=dna_;
this.jakdlugifragment=dna_.Length;


		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Imie: {0}",imie);
Console.WriteLine("Nazwisko: {0}",nazwisko);
Console.WriteLine("Wiek: {0}",ilemalat);
Console.WriteLine("Fragment DNA: {0}",dna);
Console.WriteLine("Dlugosc: {0}",jakdlugifragment);


Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}
public virtual string ZobaczDNA(){
return dna;
	}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten czlowiek jest z gatunku {1}",gatunek);		}
	}

public class PtakDNA:Ptak{
private string dna;
private int jakdlugifragment=0;	
public PtakDNA(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string dna_,int jakdlugifragment_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.dna=dna_;
this.jakdlugifragment=dna_.Length;


		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Fragment DNA: {0}",dna);
Console.WriteLine("Dlugosc: {0}",jakdlugifragment);


Console.WriteLine("_____________________________");
		}

public override string ZobaczNazwe(){
return nazwa;
		}
public virtual string ZobaczDNA(){
return dna;
	}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten ptak jest z gatunku {1}",gatunek);		}
	}

public class SsakDNA:Ssak{
private string dna;
private int jakdlugifragment=0;	
public SsakDNA(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string dna_,int jakdlugifragment_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.dna=dna_;
this.jakdlugifragment=dna_.Length;


		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Fragment DNA: {0}",dna);
Console.WriteLine("Dlugosc: {0}",jakdlugifragment);


Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}
public virtual string ZobaczDNA(){
return dna;
	}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten ssak jest z gatunku {1}",gatunek);		}
	}

public class GadDNA:Gad{
private string dna;
private int jakdlugifragment=0;	
public GadDNA(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string dna_,int jakdlugifragment_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.dna=dna_;
this.jakdlugifragment=dna_.Length;


		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Fragment DNA: {0}",dna);
Console.WriteLine("Dlugosc: {0}",jakdlugifragment);


Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}
public virtual string ZobaczDNA(){
return dna;
	}


public virtual void WyswietlGatunek(){
			Console.WriteLine("Ten gad jest z gatunku {1}",gatunek);		}
	}

public class BakteriaDNA:Bakteria{
private string dna;
private int jakdlugifragment=0;	
public BakteriaDNA(string typ_,string nazwa_,string gatunek_,string rodzina_,int wysokosc_,string dna_,int jakdlugifragmwnt_):base(typ_,nazwa_,gatunek_, rodzina_, wysokosc_) {
this.typ=typ_;
this.nazwa=nazwa_;
this.gatunek=gatunek_;
this.rodzina=rodzina_;
this.wysokosc=wysokosc_;
this.dna=dna_;
this.jakdlugifragment=dna_.Length;


		}
		
public override void InformacjeOOrganizmie(){
Console.WriteLine("Informacje o organizmie");
Console.WriteLine("Typ: {0}",typ);
Console.WriteLine("Nazwa: {0}",nazwa);
Console.WriteLine("Gatunek: {0}",gatunek);
Console.WriteLine("Rodzina: {0}",rodzina);
Console.WriteLine("Wysokosc: {0}",wysokosc);
Console.WriteLine("Fragment DNA: {0}",dna);
Console.WriteLine("Dlugosc: {0}",jakdlugifragment);


Console.WriteLine("_____________________________");
		}
public override string ZobaczNazwe(){
return nazwa;
		}
public virtual string ZobaczDNA(){
return dna;
	}
	}



	class Program
	{
public static void Main(string[] args)
		{
		//listy wszytkich organizmow, wykorzystuje on klasy pochodne
List<GadDNA> gadlista = new List<GadDNA>();
List<PtakDNA> ptaklista = new List<PtakDNA>();
List<SsakDNA> ssaklista = new List<SsakDNA>();
List<CzlowiekDNA> czlowieklista = new List<CzlowiekDNA>();
List<BakteriaDNA> bakterialista = new List<BakteriaDNA>();

//przykladowe dane
gadlista.Add(new GadDNA("Gad","Gadowy","Jakis","Rzedna",123,"TACGGACGGTTT",0));
gadlista.Add(new GadDNA("Gad","Gadowy2","Taki","Rzedna",123,"TACGGACGGTT",0));
ssaklista.Add(new SsakDNA("Ssak","Ssakowy","Rzedna","Taka",53,"TACACTGACTGC",0));
ptaklista.Add(new PtakDNA("Ptak","Ptakowy","Rzedna","Taka",27,"TACAGCTGACAG",0));
bakterialista.Add(new BakteriaDNA("Bakteria","Bakteriowy","Rzedna","Rodzinna",23,"TACATGCCGAACTATGTCGAC",0));
czlowieklista.Add(new CzlowiekDNA("SsakCzlowiek","MarekMarewski","Rzedna","Rodzinna",175,"Marek","Marewski",35,"TACATCGACATGCAG",0));

start:
//zawsze automatycznie zapisuje nazwe organizmu i jego dna (na zywo)
try{
StreamWriter test = new StreamWriter(@"C:\orgzywy\wszystkieorg.txt");
for(int i=0;i<gadlista.Count;i++){
test.WriteLine(gadlista[i].ZobaczNazwe()+" "+gadlista[i].ZobaczDNA());
} 
for(int i=0;i<ssaklista.Count;i++){
test.WriteLine(ssaklista[i].ZobaczNazwe()+" "+ssaklista[i].ZobaczDNA());
} 
for(int i=0;i<ptaklista.Count;i++){
test.WriteLine(ptaklista[i].ZobaczNazwe()+" "+ptaklista[i].ZobaczDNA());
} 
for(int i=0;i<bakterialista.Count;i++){
test.WriteLine(bakterialista[i].ZobaczNazwe()+" "+bakterialista[i].ZobaczDNA());
} 
for(int i=0;i<czlowieklista.Count;i++){
test.WriteLine(czlowieklista[i].ZobaczNazwe()+" "+czlowieklista[i].ZobaczDNA());
} 
test.Close();
}
catch(Exception e){
Console.WriteLine("..");
}	
try{
StreamReader test = new StreamReader(@"C:\orgzywy\wszystkieorg.txt");
string linia = test.ReadLine();
while (linia != null){
Console.WriteLine(linia);
linia = test.ReadLine();
}
test.Close();
}
catch(Exception e){
Console.WriteLine("..");
}
Console.Clear();
Console.WriteLine("Witaj w programie BIOLA Analyzer Made by Pawel Malicki");
Console.WriteLine("Wybierz czynnosc: ");
Console.WriteLine("1. Wyswietl wszystkie organizmy ");
Console.WriteLine("2. Wyszukaj organizm majac nazwe ");
Console.WriteLine("3. Wyszukaj organizm majac fragment DNA ");
Console.WriteLine("4. Dodaj organizm ");
Console.WriteLine("5. Usun organizm ");
Console.WriteLine("6. Przeksztalc DNA organizmu w RNA ");
Console.WriteLine("7. Pokaz bialka podczas ekspresji genu danego organizmu ");
Console.WriteLine("8. Wyswietl budowe klas (dla programistow) ");
Console.WriteLine("9. KONIEC ");
string menu=Console.ReadLine();
int cos=int.Parse(menu);
switch(cos){
case 1:
Console.WriteLine("Wszystkie gady: ");
for(int i=0;i<gadlista.Count;i++){
gadlista[i].InformacjeOOrganizmie();
}
Console.WriteLine("Wszystkie ptaki: ");
for(int i=0;i<ptaklista.Count;i++){
ptaklista[i].InformacjeOOrganizmie();
}
Console.WriteLine("Wszystkie ssaki: ");
for(int i=0;i<ssaklista.Count;i++){
ssaklista[i].InformacjeOOrganizmie();
}
Console.WriteLine("Wszystkie bakterie: ");
for(int i=0;i<bakterialista.Count;i++){
bakterialista[i].InformacjeOOrganizmie();
}
Console.WriteLine("Osoby wpisane: ");
for(int i=0;i<czlowieklista.Count;i++){
czlowieklista[i].InformacjeOOrganizmie();
}




break;


case 2:
Console.WriteLine("Wpisz nazwe: ");
string tanazwa=Console.ReadLine();
for(int i=0;i<gadlista.Count;i++){
string sprawdz=gadlista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
gadlista[i].InformacjeOOrganizmie();
break;

}
}
for(int i=0;i<ssaklista.Count;i++){
string sprawdz=ssaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
ssaklista[i].InformacjeOOrganizmie();
break;

}
}
for(int i=0;i<ptaklista.Count;i++){
string sprawdz=ptaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
ptaklista[i].InformacjeOOrganizmie();
break;
}
}
for(int i=0;i<bakterialista.Count;i++){
string sprawdz=bakterialista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
bakterialista[i].InformacjeOOrganizmie();
break;

}
}
for(int i=0;i<czlowieklista.Count;i++){
string sprawdz=czlowieklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
czlowieklista[i].InformacjeOOrganizmie();
break;

}
}









break;
case 3:
Console.WriteLine("Wpisz fragment DNA: ");
tanazwa=Console.ReadLine();
for(int i=0;i<gadlista.Count;i++){
string sprawdz=gadlista[i].ZobaczDNA();
if(sprawdz==tanazwa){
gadlista[i].InformacjeOOrganizmie();
break;

}
}
for(int i=0;i<ssaklista.Count;i++){
string sprawdz=ssaklista[i].ZobaczDNA();
if(sprawdz==tanazwa){
ssaklista[i].InformacjeOOrganizmie();
break;
}
}
for(int i=0;i<ptaklista.Count;i++){
string sprawdz=ptaklista[i].ZobaczDNA();
if(sprawdz==tanazwa){
ptaklista[i].InformacjeOOrganizmie();
break;
}
}
for(int i=0;i<bakterialista.Count;i++){
 string sprawdz=bakterialista[i].ZobaczDNA();
if(sprawdz==tanazwa){
bakterialista[i].InformacjeOOrganizmie();
break;
}
}
for(int i=0;i<czlowieklista.Count;i++){
 string sprawdz=czlowieklista[i].ZobaczDNA();
if(sprawdz==tanazwa){
czlowieklista[i].InformacjeOOrganizmie();
break;
}
}










break;


case 4:
Console.WriteLine("Podaj typ organizmu: ");
Console.WriteLine("1. Gad ");
Console.WriteLine("2. Ssak ");
Console.WriteLine("3. Ptak ");
Console.WriteLine("4. Bakteria ");
Console.WriteLine("5. Człowiek* ");
string kto=Console.ReadLine();
if(kto=="1"){
Console.WriteLine("Podaj nazwe:");
string nazwao =Console.ReadLine();
Console.WriteLine("Podaj gatunek");
string gatuneko =Console.ReadLine();
Console.WriteLine("Podaj rodzine:");
string rodzinao =Console.ReadLine();
Console.WriteLine("Podaj wysokosc:");
string wysokosco =Console.ReadLine();
int wysok=int.Parse(wysokosco);
Console.WriteLine("Podaj fragment DNA:");
string dnao =Console.ReadLine();
gadlista.Add(new GadDNA("Gad",nazwao,gatuneko,rodzinao,wysok,dnao,dnao.Length));
Console.WriteLine("Organizm został dodany . . .");
}else if(kto=="2"){
Console.WriteLine("Podaj nazwe:");
string nazwao =Console.ReadLine();
Console.WriteLine("Podaj gatunek");
string gatuneko =Console.ReadLine();
Console.WriteLine("Podaj rodzine:");
string rodzinao =Console.ReadLine();
Console.WriteLine("Podaj wysokosc:");
string wysokosco =Console.ReadLine();
int wysok=int.Parse(wysokosco);
Console.WriteLine("Podaj fragment DNA:");
string dnao =Console.ReadLine();
ssaklista.Add(new SsakDNA("Ssak",nazwao,gatuneko,rodzinao,wysok,dnao,0));
Console.WriteLine("Organizm został dodany . . .");
}  
else if(kto=="3"){
Console.WriteLine("Podaj nazwe:");
string nazwao =Console.ReadLine();
Console.WriteLine("Podaj gatunek");
string gatuneko =Console.ReadLine();
Console.WriteLine("Podaj rodzine:");
string rodzinao =Console.ReadLine();
Console.WriteLine("Podaj wysokosc:");
string wysokosco =Console.ReadLine();
int wysok=int.Parse(wysokosco);
Console.WriteLine("Podaj fragment DNA:");
string dnao =Console.ReadLine();
ptaklista.Add(new PtakDNA("Ptak",nazwao,gatuneko,rodzinao,wysok,dnao,0));
Console.WriteLine("Organizm został dodany . . .");
}  
else if(kto=="4"){
Console.WriteLine("Podaj nazwe:");
string nazwao =Console.ReadLine();
Console.WriteLine("Podaj gatunek");
string gatuneko =Console.ReadLine();
Console.WriteLine("Podaj rodzine:");
string rodzinao =Console.ReadLine();
Console.WriteLine("Podaj wysokosc:");
string wysokosco =Console.ReadLine();
int wysok=int.Parse(wysokosco);
Console.WriteLine("Podaj fragment DNA:");
string dnao =Console.ReadLine();
bakterialista.Add(new BakteriaDNA("Bakteria",nazwao,gatuneko,rodzinao,wysok,dnao,0));
Console.WriteLine("Organizm został dodany . . .");
}  else if(kto=="5"){
Console.WriteLine("Podaj nazwe:");
string nazwao =Console.ReadLine();
Console.WriteLine("Podaj gatunek");
string gatuneko =Console.ReadLine();
Console.WriteLine("Podaj rodzine:");
string rodzinao =Console.ReadLine();
Console.WriteLine("Podaj wysokosc:");
string wysokosco =Console.ReadLine();
Console.WriteLine("Podaj imie:");
string imieo =Console.ReadLine();
Console.WriteLine("Podaj nazwisko:");
string nazwiskoo =Console.ReadLine();
Console.WriteLine("Podaj wiek:");
string wiekoo =Console.ReadLine();
int wiekaa=int.Parse(wiekoo);
int wysok=int.Parse(wysokosco);
Console.WriteLine("Podaj fragment DNA:");
string dnao =Console.ReadLine();
czlowieklista.Add(new CzlowiekDNA("SsakCzlowiek",nazwao,gatuneko,rodzinao,wysok,imieo,nazwiskoo,wiekaa,dnao,0));
Console.WriteLine("Organizm został dodany . . .");
}  else{
Console.WriteLine("Taki typ nie istnieje...");

}





break;
case 5:
Console.WriteLine("Podaj nazwe organizmu, który chcesz usunac: ");
tanazwa=Console.ReadLine();
for(int i=0;i<gadlista.Count;i++){
string sprawdz=gadlista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
gadlista.RemoveAt(i);
Console.WriteLine("Organizm został usuniety . . .");

break;
}
}

for(int i=0;i<ssaklista.Count;i++){
string sprawdz=ssaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
ssaklista.RemoveAt(i);
Console.WriteLine("Organizm został usuniety . . .");

break;
}
}
for(int i=0;i<ptaklista.Count;i++){
string sprawdz=ptaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
ptaklista.RemoveAt(i);
Console.WriteLine("Organizm został usuniety . . .");

break;
}
}
for(int i=0;i<bakterialista.Count;i++){
 string sprawdz=bakterialista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
bakterialista.RemoveAt(i);
Console.WriteLine("Organizm został usuniety . . .");

break;
}
}
for(int i=0;i<czlowieklista.Count;i++){
string sprawdz=czlowieklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
czlowieklista.RemoveAt(i);
Console.WriteLine("Organizm został usuniety . . .");

break;
}
}










break;
case 6:
Console.WriteLine("Wpisz nazwe organizmu, potem zostanie przeksztalcone DNA w RNA: ");
 tanazwa=Console.ReadLine();
for(int i=0;i<gadlista.Count;i++){
string sprawdz=gadlista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=gadlista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
string rna="";
for(int j=0;j<moje.Length;j++){
if(moje[j]=='A'){
rna=rna+"U";
}
if(moje[j]=='G'){
rna=rna+"C";
}
if(moje[j]=='C'){
rna=rna+"G";
}
if(moje[j]=='T'){
rna=rna+"A";
}

}

Console.WriteLine("RNA: {0}",rna);

break;
}
}

for(int i=0;i<ssaklista.Count;i++){
 string sprawdz=ssaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=ssaklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
string rna="";
for(int j=0;j<moje.Length;j++){
if(moje[j]=='A'){
rna=rna+"U";
}
if(moje[j]=='G'){
rna=rna+"C";
}
if(moje[j]=='C'){
rna=rna+"G";
}
if(moje[j]=='T'){
rna=rna+"A";
}

}

Console.WriteLine("RNA: {0}",rna);

break;
}
}
for(int i=0;i<ptaklista.Count;i++){
string sprawdz=ptaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=ptaklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
string rna="";
for(int j=0;j<moje.Length;j++){
if(moje[j]=='A'){
rna=rna+"U";
}
if(moje[j]=='G'){
rna=rna+"C";
}
if(moje[j]=='C'){
rna=rna+"G";
}
if(moje[j]=='T'){
rna=rna+"A";
}

}
Console.WriteLine("RNA: {0}",rna);


break;
}
}
for(int i=0;i<bakterialista.Count;i++){
string sprawdz=bakterialista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=bakterialista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
string rna="";
for(int j=0;j<moje.Length;j++){
if(moje[j]=='A'){
rna=rna+"U";
}
if(moje[j]=='G'){
rna=rna+"C";
}
if(moje[j]=='C'){
rna=rna+"G";
}
if(moje[j]=='T'){
rna=rna+"A";
}

}
Console.WriteLine("RNA: {0}",rna);


break;
}
}
for(int i=0;i<czlowieklista.Count;i++){
string sprawdz=czlowieklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=czlowieklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
string rna="";
for(int j=0;j<moje.Length;j++){
if(moje[j]=='A'){
rna=rna+"U";
}
if(moje[j]=='G'){
rna=rna+"C";
}
if(moje[j]=='C'){
rna=rna+"G";
}
if(moje[j]=='T'){
rna=rna+"A";
}

}

Console.WriteLine("RNA: {0}",rna);

break;
}
}










break;

case 7:
Console.WriteLine("Wpisz nazwe organizmu, potem zostanie przeksztalcone DNA w bialka: ");
 tanazwa=Console.ReadLine();
for(int i=0;i<gadlista.Count;i++){
string sprawdz=gadlista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=gadlista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
if(moje.Length%3!=0){
Console.WriteLine("Ten kod genetyczny jest zepsuty, nie mozna go podzielic na 3!");
break;
}
string rna="";
for(int j=0;j<moje.Length;j++){
	
	
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Mationina ";
}
	
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Walina ";
}
	
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Seryna ";
}
	
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Prolina ";
}
	
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Treonina ";
}
	
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Alanina ";
}
	
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" STOP ";
}
	
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Glutamina ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Glutamina ";
}
	
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Lizyna ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Lizyna ";
}
	
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Kwas glutaminowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Kwas glutaminowy ";
}
	
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Tryptolan ";
}
	
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Glicyna ";
}
j++;
j++;

}
Console.WriteLine("Bialka: {0}",rna);

break;
}
}

for(int i=0;i<ssaklista.Count;i++){
string sprawdz=ssaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=ssaklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
if(moje.Length%3!=0){
Console.WriteLine("Ten kod genetyczny jest zepsuty, nie mozna go podzielic na 3!");
break;
}
string rna="";
for(int j=0;j<moje.Length;j++){

	
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Mationina ";
}
	
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Walina ";
}
	
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Seryna ";
}
	
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Prolina ";
}
	
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Treonina ";
}
	
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Alanina ";
}
	
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" STOP ";
}
	
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Glutamina ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Glutamina ";
}
	
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Lizyna ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Lizyna ";
}
	
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Kwas glutaminowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Kwas glutaminowy ";
}
	
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Tryptolan ";
}
	
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Glicyna ";
}
j++;
j++;



}
Console.WriteLine("Bialka: {0}",rna);

break;
}
}
for(int i=0;i<ptaklista.Count;i++){
string sprawdz=ptaklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=ptaklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
if(moje.Length%3!=0){
Console.WriteLine("Ten kod genetyczny jest zepsuty, nie mozna go podzielic na 3!");
break;
}
string rna="";
for(int j=0;j<moje.Length;j++){

	
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Mationina ";
}
	
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Walina ";
}
	
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Seryna ";
}
	
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Prolina ";
}
	
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Treonina ";
}
	
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Alanina ";
}
	
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" STOP ";
}
	
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Glutamina ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Glutamina ";
}
	
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Lizyna ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Lizyna ";
}
	
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Kwas glutaminowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Kwas glutaminowy ";
}
	
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Tryptolan ";
}
	
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Glicyna ";
}
j++;
j++;


}
Console.WriteLine("Bialka: {0}",rna);

break;
}
}
for(int i=0;i<bakterialista.Count;i++){
 string sprawdz=bakterialista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=bakterialista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
if(moje.Length%3!=0){
Console.WriteLine("Ten kod genetyczny jest zepsuty, nie mozna go podzielic na 3!");
break;
}
string rna="";
for(int j=0;j<moje.Length;j++){

	
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Mationina ";
}
	
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Walina ";
}
	
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Seryna ";
}
	
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Prolina ";
}
	
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Treonina ";
}
	
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Alanina ";
}
	
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" STOP ";
}
	
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Glutamina ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Glutamina ";
}
	
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Lizyna ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Lizyna ";
}
	
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Kwas glutaminowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Kwas glutaminowy ";
}
	
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Tryptolan ";
}
	
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Glicyna ";
}
j++;
j++;

	
}
Console.WriteLine("Bialka: {0}",rna);

break;
}
}
for(int i=0;i<czlowieklista.Count;i++){
string sprawdz=czlowieklista[i].ZobaczNazwe();
if(sprawdz==tanazwa){
string moje=czlowieklista[i].ZobaczDNA();
Console.WriteLine("DNA: {0}",moje);
if(moje.Length%3!=0){
Console.WriteLine("Ten kod genetyczny jest zepsuty, nie mozna go podzielic na 3!");
break;
}
string rna="";
for(int j=0;j<moje.Length;j++){

	
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Fenylo-alanina ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='A' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Leucyna ";
}
if(moje[j]=='G' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Leucyna ";
}
	
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Izoleucyna ";
}
if(moje[j]=='T' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Mationina ";
}
	
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='A'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='G'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='T'){
rna=rna+" Walina ";
}
if(moje[j]=='C' && moje[j+1]=='A' && moje[j+2]=='C'){
rna=rna+" Walina ";
}
	
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Seryna ";
}
if(moje[j]=='A' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Seryna ";
}
	
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Prolina ";
}
if(moje[j]=='G' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Prolina ";
}
	
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Treonina ";
}
if(moje[j]=='T' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Treonina ";
}
	
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='A'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='G'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='T'){
rna=rna+" Alanina ";
}
if(moje[j]=='C' && moje[j+1]=='G' && moje[j+2]=='C'){
rna=rna+" Alanina ";
}
	
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Tyrozyna ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" STOP ";
}
	
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Histydyna ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Glutamina ";
}
if(moje[j]=='G' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Glutamina ";
}
	
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Asparagina ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Lizyna ";
}
if(moje[j]=='T' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Lizyna ";
}
	
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='A'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='G'){
rna=rna+" Kwas asparginowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='T'){
rna=rna+" Kwas glutaminowy ";
}
if(moje[j]=='C' && moje[j+1]=='T' && moje[j+2]=='C'){
rna=rna+" Kwas glutaminowy ";
}
	
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Cysteina ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" STOP ";
}
if(moje[j]=='A' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Tryptolan ";
}
	
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='G' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Seryna ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Arginina ";
}
if(moje[j]=='T' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Arginina ";
}
	
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='A'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='G'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='T'){
rna=rna+" Glicyna ";
}
if(moje[j]=='C' && moje[j+1]=='C' && moje[j+2]=='C'){
rna=rna+" Glicyna ";
}
j++;
j++;


}
Console.WriteLine("Bialka: {0}",rna);

break;
}
}








break;


case 8:
Console.WriteLine("Klasy:::");
Console.WriteLine("OrganizmyZywe");
Console.WriteLine("-Ptak");
Console.WriteLine("--SsakiDNA");
Console.WriteLine("-Gad");
Console.WriteLine("--GadDNA");
Console.WriteLine("-Ssaki");
Console.WriteLine("--SsakiDNA");
Console.WriteLine("--Czlowiek");
Console.WriteLine("---CzlowiekDNA");

Console.WriteLine("-Bakteria");
Console.WriteLine("--BakteriaDNA");
Console.WriteLine(":::::");




break;
case 9:
goto koniec;

}
Console.WriteLine("Kliknij aby wrocic do menu...");

Console.ReadKey(true);

goto start;
koniec:				   Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}

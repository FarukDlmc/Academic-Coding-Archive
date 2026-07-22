class YemekSorusu{
  
  const YemekSorusu(this.soru, this.cevaplar);

  final String soru;
  final List<String> cevaplar;

  List<String> karmaCevaplar(){
    final karma = List.of(cevaplar);
    karma.shuffle();
    return karma;
  }

}

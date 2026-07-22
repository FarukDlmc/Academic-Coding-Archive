class Dizi{

  Dizi({
    required this.id, required this.baslik, required this.imageURL,
    required this.kategoriler, required this.oyuncular, required this.platform, this.favoriMi = false,
    required this.sezonSayisi, required this.bolumSayisi, required this.imdbPuani, required this.izleyiciDuzeyi,
  });

  final String id, baslik, imageURL;
  final List<String> kategoriler;
  final List<String> oyuncular;
  final List<String> platform;
  final int sezonSayisi, bolumSayisi;
  final double imdbPuani;
  final String izleyiciDuzeyi;
  bool favoriMi;

}
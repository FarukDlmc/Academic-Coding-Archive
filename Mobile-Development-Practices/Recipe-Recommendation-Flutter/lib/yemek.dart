import 'package:flutter/material.dart';
import 'package:yemek/data/sorular.dart';
import 'package:yemek/data/tarifler.dart';
import 'package:yemek/giris_ekrani.dart';
import 'package:yemek/models/yemek_tarifi.dart';
import 'package:yemek/soru_ekrani.dart';
import 'package:yemek/tarif_ekrani.dart';

class Yemek extends StatefulWidget {
  const Yemek({super.key});

  @override
  State<Yemek> createState() {
    return _YemekState();
  }
}

class _YemekState extends State<Yemek> {
  late String aktifEkran; //Widget
  final List<String> verilenCevaplar = [];

  late Widget aktifEkranWidget;

  @override
  void initState() {
    aktifEkran = "giris-ekrani"; //
    aktifEkranWidget = GirisEkrani(ekranDegistir: ekranDegistir);
    super.initState();
  }

  void ekranDegistir() {
    setState(() {
      if (aktifEkran == 'giris-ekrani') {
        aktifEkran = 'soru-ekrani';
        aktifEkranWidget = SoruEkrani(cevapEkle: cevapEkle);
      } else if (aktifEkran == 'tarif-ekrani') {
        aktifEkran = 'giris-ekrani';
        aktifEkranWidget = GirisEkrani(ekranDegistir: ekranDegistir);
      }
    });
  }

  void cevapEkle(String cevap) {
    verilenCevaplar.add(cevap);
    if (verilenCevaplar.length == sorular.length) {
      setState(() {
        aktifEkran = 'tarif-ekrani';
        aktifEkranWidget = TarifEkrani(
          uygunTarifler: uygunTarifBul(verilenCevaplar, tarifler),
          ekranDegistir: ekranDegistir,
        );
        verilenCevaplar.clear();        
      });
    }
  }

  List<YemekTarifi> uygunTarifBul(
    List<String> verilenCevaplar,
    List<YemekTarifi> tarifler,
  ) {
    List<YemekTarifi> list = [];
    for (YemekTarifi yt in tarifler) {
      if (yt.malzemeler.toSet().intersection(verilenCevaplar.toSet()).length ==
          yt.malzemeler.length) {
        list.add(yt);
      }
    }
    return list;
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Container(
          decoration: BoxDecoration(
            gradient: LinearGradient(
              colors: [Colors.deepPurpleAccent, Colors.deepOrangeAccent],
              begin: Alignment.topLeft,
              end: Alignment.bottomCenter,
            ),
          ),
          child: aktifEkranWidget,
        ),
      ),
    );
  }
}

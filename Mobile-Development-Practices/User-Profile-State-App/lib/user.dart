import 'package:flutter/material.dart';
import 'package:kullanici_bilgisi_gosterme/giris_ekrani.dart';
import 'package:kullanici_bilgisi_gosterme/ad_guncelleme_ekrani.dart';
import 'package:kullanici_bilgisi_gosterme/soyad_guncelleme_ekrani.dart';
import 'package:kullanici_bilgisi_gosterme/yas_guncelleme_ekrani.dart';

class User extends StatefulWidget {
  const User({super.key});

  @override
  State<User> createState() => _UserState();
}

class _UserState extends State<User> {
  late String aktifEkran;
  String? guncellenecekAlan;
  
  // Kullanıcı bilgilerini tutan değişkenler
  String kullaniciAdi = '';
  String kullaniciSoyadi = '';
  String kullaniciYasi = '';

  @override
  void initState() {
    aktifEkran = "giris-ekrani";
    super.initState();
  }

  void ekranDegistir(String alan) {
    setState(() {
      aktifEkran = "guncelleme-ekrani";
      guncellenecekAlan = alan;
    });
  }

  void anaEkranaDon({bool kaydet = false}) {
    setState(() {
      aktifEkran = "giris-ekrani";
    });
  }

  void bilgiGuncelle(String alan, String deger) {
    setState(() {
      switch (alan) {
        case 'ad':
          kullaniciAdi = deger;
          break;
        case 'soyad':
          kullaniciSoyadi = deger;
          break;
        case 'yas':
          kullaniciYasi = deger;
          break;
      }
    });
    anaEkranaDon();
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Container(
          decoration: const BoxDecoration(
            gradient: LinearGradient(
              colors: [Colors.deepPurpleAccent, Colors.deepOrangeAccent],
              begin: Alignment.topLeft,
              end: Alignment.bottomCenter,
            ),
          ),
          child: aktifEkran == "giris-ekrani"
              ? GirisEkrani(
                  ekranDegistir: ekranDegistir,
                  ad: kullaniciAdi,
                  soyad: kullaniciSoyadi,
                  yas: kullaniciYasi,
                )
              : _guncellemeEkraniGetir(),
        ),
      ),
    );
  }

  Widget _guncellemeEkraniGetir() {
    switch (guncellenecekAlan) {
      case 'ad':
        return AdGuncellemeEkrani(
          anaEkranaDon: anaEkranaDon,
          bilgiGuncelle: bilgiGuncelle,
          mevcutDeger: kullaniciAdi,
        );
      case 'soyad':
        return SoyadGuncellemeEkrani(
          anaEkranaDon: anaEkranaDon,
          bilgiGuncelle: bilgiGuncelle,
          mevcutDeger: kullaniciSoyadi,
        );
      case 'yas':
        return YasGuncellemeEkrani(
          anaEkranaDon: anaEkranaDon,
          bilgiGuncelle: bilgiGuncelle,
          mevcutDeger: kullaniciYasi,
        );
      default:
        return GirisEkrani(
          ekranDegistir: ekranDegistir,
          ad: kullaniciAdi,
          soyad: kullaniciSoyadi,
          yas: kullaniciYasi,
        );
    }
  }
}
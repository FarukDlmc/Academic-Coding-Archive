import 'package:dizi_app/data/gecici_veri.dart';
import 'package:dizi_app/models/dizi.dart';
import 'package:dizi_app/screens/diziler_ekrani.dart';
import 'package:dizi_app/screens/kategori_ekrani.dart';
import 'package:flutter/material.dart';

class TabEkrani extends StatefulWidget{

  const TabEkrani({super.key});

  @override
  State<TabEkrani> createState() {
    return _TabEkraniState();
  }

}

class _TabEkraniState extends State<TabEkrani>{
  int _secilenEkran = 0;

  void _ekranSec(int index){
    setState(() {
      _secilenEkran = index;
    });
  }

  void _favoriSec(Dizi dizi){
    setState(() {
      dizi.favoriMi = !dizi.favoriMi;
    });
  }

  @override
  Widget build(context){

    Widget aktifEkran = _secilenEkran == 0 ? KategoriEkrani(favoriSec: _favoriSec,) : DizilerEkrani(diziler: diziler.where((element) => element.favoriMi).toList(), favoriSec: _favoriSec,);
    String aktifEkranBaslik = _secilenEkran == 0 ? 'Kategoriler' : 'Favoriler';

    return Scaffold(
      appBar: AppBar(
        title: Text(aktifEkranBaslik),
      ),
      body: aktifEkran,
      bottomNavigationBar: BottomNavigationBar(
        onTap: _ekranSec,
        currentIndex: _secilenEkran,
        items: const [
          BottomNavigationBarItem(icon: Icon(Icons.play_arrow), label: 'Kategoriler',),
          BottomNavigationBarItem(icon: Icon(Icons.favorite), label: 'Favoriler',),
        ],
      ),
    );
  }
}
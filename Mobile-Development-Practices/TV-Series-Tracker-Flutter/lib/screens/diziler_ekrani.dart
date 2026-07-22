import 'package:dizi_app/models/dizi.dart';
import 'package:dizi_app/screens/dizi_detay_ekrani.dart';
import 'package:dizi_app/widgets/dizi_item.dart';
import 'package:flutter/material.dart';

class DizilerEkrani extends StatelessWidget {
  const DizilerEkrani({super.key, required this.diziler, this.kategori, required this.favoriSec});

  final List<Dizi> diziler;
  final String? kategori;
  final Function(Dizi dizi) favoriSec;

  void _diziSec(BuildContext context, Dizi dizi) {
    Navigator.of(context).push(MaterialPageRoute(
        builder: (ctx) => DiziDetayEkrani(
              dizi: dizi, favoriSec: favoriSec,
            )));
  }

  @override
  Widget build(context) {

    Widget content = (diziler.isEmpty)
          ? Center(
              child: Text('Bu kategoride dizi bulunamadı.',
                  style: Theme.of(context).textTheme.bodyLarge!.copyWith(
                        color: Theme.of(context).colorScheme.onSurface,
                      )),
            )
          : ListView.builder(
            itemCount: diziler.length,
              itemBuilder: (context, index) {
                return DiziItem(dizi: diziler[index], diziSec: (dizi){
                  _diziSec(context, dizi);
                },);
              },
            );

    return kategori == null ? content : Scaffold(
      appBar: AppBar(
        title: Text(kategori!),
      ),
      body: content,
    );
  }
}

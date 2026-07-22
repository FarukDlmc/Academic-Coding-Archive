import 'package:dizi_app/data/gecici_veri.dart';
import 'package:dizi_app/models/dizi.dart';
import 'package:dizi_app/models/kategori.dart';
import 'package:dizi_app/screens/diziler_ekrani.dart';
import 'package:dizi_app/widgets/kategori_grid_item.dart';
import 'package:flutter/material.dart';

class KategoriEkrani extends StatelessWidget {
  const KategoriEkrani({super.key, required this.favoriSec});

  final Function(Dizi dizi) favoriSec;

  void _kategoriSec(BuildContext context, Kategori kategori) {
    final filtrelenmisDiziler = diziler
        .where((dizi) => dizi.kategoriler.contains(kategori.id))
        .toList();
    Navigator.of(context).push(MaterialPageRoute(
        builder: (ctx) => DizilerEkrani(
              kategori: kategori.baslik,
              diziler: filtrelenmisDiziler,
              favoriSec: favoriSec,
            )));
  }

  @override
  Widget build(context) {
    return GridView(
      padding: const EdgeInsets.all(24),
      gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
        crossAxisCount: 2,
        childAspectRatio: 3 / 2,
        crossAxisSpacing: 20,
        mainAxisSpacing: 20,
      ),
      children: [
        for (final kategori in kategoriler)
          KategoriGridItem(
            kategori: kategori,
            kategoriSec: () {
              _kategoriSec(context, kategori);
            },
          ),
      ],
    );
  }
}

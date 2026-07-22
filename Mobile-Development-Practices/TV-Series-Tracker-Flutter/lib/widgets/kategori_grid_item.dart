import 'package:dizi_app/models/kategori.dart';
import 'package:flutter/material.dart';

class KategoriGridItem extends StatelessWidget{
  const KategoriGridItem({super.key, required this.kategori, required this.kategoriSec});

  final Kategori kategori;
  final void Function() kategoriSec;

  @override
  Widget build(context){
    return InkWell(
      onTap: kategoriSec,
      splashColor: Theme.of(context).primaryColor,
      borderRadius: BorderRadius.circular(16),
      child: Container(
        padding: const EdgeInsets.all(16),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(16),
          gradient: LinearGradient(colors: [kategori.renk.withAlpha(140), kategori.renk.withAlpha(230),],
          begin: Alignment.topCenter, end: Alignment.bottomCenter,)
        ),
        child: Text(kategori.baslik,
        style: Theme.of(context).textTheme.titleLarge!.copyWith(
          color: Theme.of(context).colorScheme.onSurface,
        ),),
      ),
    );
  }

}
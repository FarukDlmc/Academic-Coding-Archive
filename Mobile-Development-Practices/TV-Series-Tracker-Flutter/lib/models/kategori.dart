import 'package:flutter/material.dart';

class  Kategori{

  const Kategori({
    required this.id, 
    required this.baslik, 
    this.renk = Colors.yellowAccent,
  });

  final String id, baslik;
  final Color renk;
}
//import 'package:dizi_app/screens/diziler_ekrani.dart';
import 'package:dizi_app/screens/tabs.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
//import 'package:dizi_app/data/gecici_veri.dart';

final theme = ThemeData(
  colorScheme: ColorScheme.fromSeed(
    brightness: Brightness.dark,
    seedColor: Colors.deepOrangeAccent,),
  textTheme: GoogleFonts.ubuntuTextTheme(),
);
void main() {
  runApp(const MainApp());
}

class MainApp extends StatelessWidget {
  const MainApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: theme,
      home: const TabEkrani(),
    );
  }
}

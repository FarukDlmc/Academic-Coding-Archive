import 'package:flutter/material.dart';
import 'package:yemek/cevap_butonu.dart';
import 'data/sorular.dart';

import 'package:google_fonts/google_fonts.dart';

class SoruEkrani extends StatefulWidget {

  final void Function(String cevap) cevapEkle; 
  const SoruEkrani({super.key, required this.cevapEkle});

  @override
  State<StatefulWidget> createState() {
    return _SoruEkraniState();
  }
}

class _SoruEkraniState extends State<SoruEkrani> {

  int mevcutSoruIndex = 0; 
   

  @override
  Widget build(BuildContext context) {
    
    return SizedBox(
      width: double.infinity,
      child: Container(
        margin: const EdgeInsets.all(40),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Image.asset(
            'assets/images/chef.png',
            height: 240,
            color: const Color.fromARGB(150, 255, 255, 255),
            ),
            const SizedBox(height: 80),
            Text(sorular[mevcutSoruIndex].soru,
            style: GoogleFonts.alkatra(
              color: Colors.white,
              fontSize: 24,),
            ),
            const SizedBox(height: 30),
            ...sorular[mevcutSoruIndex].karmaCevaplar().map((cevap){
              return CevapButonu(cevap, () {
                setState(() {
                  widget.cevapEkle(cevap);                  
                  mevcutSoruIndex++;
                });
              });
            }),
        
          ],
        ),
      ),
    );
  }
}

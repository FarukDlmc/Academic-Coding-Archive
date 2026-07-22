import 'package:flutter/material.dart';
import 'package:zar_at/beautiful_container.dart';

// Nesneleri-widget’ları iç içe yerleştirmeye devam ediyoruz
void main() {
  // Derleyici tarafından otomatik olarak çalıştırılan giriş metodu
  runApp(
    // Hangi ara yüz öğelerinin görüntüleneceğini belirten metot.
    MaterialApp(
      home: Scaffold(
        body: BeautifulContainer(
          Alignment.bottomLeft,
          Alignment.topRight,
          colors: [const Color.fromARGB(255, 74, 177, 195), const Color.fromARGB(255, 65, 255, 103)],
        ),
      ),
    ),
  );
}

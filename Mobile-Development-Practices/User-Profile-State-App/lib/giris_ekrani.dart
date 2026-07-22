import 'package:flutter/material.dart';

class GirisEkrani extends StatelessWidget {
  final void Function(String) ekranDegistir;
  final String ad;
  final String soyad;
  final String yas;

  // Kullanıcı bilgilerini tutan TextEditingController'lar. (Bilgileri yönetmek için; güncelleme vs.)
  final TextEditingController _adController;
  final TextEditingController _soyadController;
  final TextEditingController _yasController;

  GirisEkrani({
    super.key,
    required this.ekranDegistir,
    required this.ad,
    required this.soyad,
    required this.yas,
  }) : _adController = TextEditingController(text: ad),
       _soyadController = TextEditingController(text: soyad),
       _yasController = TextEditingController(text: yas);

  @override
  Widget build(BuildContext context) {
    return Center(
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            ClipOval(
              child: Image.asset(
                'assets/images/userr.png',
                width: 200,
                height: 200,
                fit: BoxFit.cover, //resmi sığdırma.
              ),
            ),
            const SizedBox(height: 40),
            const Text(
              'Hoşgeldiniz',
              style: TextStyle(
                color: Color.fromARGB(255, 255, 0, 0),
                fontSize: 24,
              ),
            ),
            const SizedBox(height: 30),

            // Ad Satırı
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 10),
              child: Row(
                children: [
                  Expanded(
                    child: TextField(
                      controller: _adController,
                      readOnly: true,
                      decoration: InputDecoration(
                        labelText: 'Ad',
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(10),
                        ),
                      ),
                    ),
                  ),
                  const SizedBox(width: 10),
                  ElevatedButton(
                    onPressed: () => ekranDegistir('ad'),
                    child: const Text('Güncelle'),
                  ),
                ],
              ),
            ),

            // Soyad Satırı
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 10),
              child: Row(
                children: [
                  Expanded(
                    child: TextField(
                      controller: _soyadController,
                      readOnly: true,
                      decoration: InputDecoration(
                        labelText: 'Soyad',
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(10),
                        ),
                      ),
                    ),
                  ),
                  const SizedBox(width: 10),
                  ElevatedButton(
                    onPressed: () => ekranDegistir('soyad'),
                    child: const Text('Güncelle'),
                  ),
                ],
              ),
            ),

            // Yaş Satırı
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 40, vertical: 10),
              child: Row(
                children: [
                  Expanded(
                    child: TextField(
                      controller: _yasController,
                      readOnly: true,
                      keyboardType: TextInputType.number,
                      decoration: InputDecoration(
                        labelText: 'Yaş',
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(10),
                        ),
                      ),
                    ),
                  ),
                  const SizedBox(width: 10),
                  ElevatedButton(
                    onPressed: () => ekranDegistir('yas'),
                    child: const Text('Güncelle'),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}

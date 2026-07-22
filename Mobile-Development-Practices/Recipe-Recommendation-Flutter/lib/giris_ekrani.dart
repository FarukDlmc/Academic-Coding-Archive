import 'package:flutter/material.dart';

class GirisEkrani extends StatelessWidget {

  final void Function() ekranDegistir;

  const GirisEkrani({super.key, required this.ekranDegistir});

  @override
  Widget build(BuildContext context) {
    return Center(
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Image.asset(
            'assets/images/chef.png',
            width: 200,
            color: const Color.fromARGB(150, 255, 255, 255),
          ),
          const SizedBox(height: 80),
          const Text(
            'Hadi yemek yapalım!',
            style: TextStyle(
              color: Color.fromARGB(255, 238, 241, 255),
              fontSize: 24,
            ),
          ),
          const SizedBox(height: 30),
          OutlinedButton.icon(
            onPressed: ekranDegistir,
            style: OutlinedButton.styleFrom(
              foregroundColor: const Color.fromARGB(255, 238, 241, 255),
              shape: const RoundedRectangleBorder(
                borderRadius: BorderRadius.all(Radius.circular(7)),
              ),
              side: const BorderSide(color: Color.fromARGB(38, 255, 255, 255)),
            ),
            icon: Icon(Icons.food_bank),
            label: const Text('Başlayalım'),
          ),
        ],
      ),
    );
  }
}

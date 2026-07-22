import 'package:flutter/material.dart';
import 'dart:math';

import 'package:zar_at/my_text.dart';
import 'package:zar_at/nice_button.dart';

class RollerWidget extends StatefulWidget {
  const RollerWidget({super.key});
  @override
  State<RollerWidget> createState() {
    return _RollerWidgetState();
  }
}

class _RollerWidgetState extends State<RollerWidget> {
  int zar = 1;
  int zar1 = 3;
  int zar2 = 6;

  void zarAt() {
    setState(() {
      zar = Random().nextInt(6) + 1;
      zar1 = Random().nextInt(6) + 1;
      zar2 = Random().nextInt(6) + 1;
    });
  }

  @override
  Widget build(context) {
    return Column(
      mainAxisSize: MainAxisSize.min,
      children: [
        const Text(
          '3 Zar Atışı',
          style: TextStyle(
            color: Colors.deepOrange,
            fontSize: 24,
            fontWeight: FontWeight.bold
          ),
        
        ),
        const SizedBox(height: 50),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Image.asset('assets/images/zar$zar.png', width: 130),
            Image.asset('assets/images/zar$zar1.png', width: 130),
            Image.asset('assets/images/zar$zar2.png', width: 130),
          ],
        ),
        const SizedBox(height: 20),
        NiceButton.green(
          onPressed: zarAt,
          style: TextButton.styleFrom(
            foregroundColor: Colors.red,
            textStyle: const TextStyle(fontSize: 24),
          ),
          child: const MyText("Zar At"))
      ],
    );
  }
}

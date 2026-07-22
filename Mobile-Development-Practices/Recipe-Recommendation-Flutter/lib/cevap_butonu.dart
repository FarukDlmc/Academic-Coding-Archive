import 'package:flutter/material.dart';

class CevapButonu extends StatelessWidget {

  const CevapButonu(this.text, this.pressed, {super.key});

  final String text;
  final void Function() pressed;

  @override
  Widget build(context) {
    return Column(
      mainAxisAlignment: MainAxisAlignment.center,
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        ElevatedButton(
          onPressed: pressed,
          style: ElevatedButton.styleFrom(
            backgroundColor: const Color.fromARGB(38, 108, 0, 197),
            foregroundColor: Colors.white,
            //shape: const RoundedRectangleBorder(borderRadius: BorderRadius.all(Radius.circular(5))),
            padding: const EdgeInsets.symmetric(vertical: 10, horizontal: 40),
          ),
          child: Text(text, style: const TextStyle(fontSize: 16)),
        ),
        SizedBox(height: 4,),
      ],
    );
  }
}

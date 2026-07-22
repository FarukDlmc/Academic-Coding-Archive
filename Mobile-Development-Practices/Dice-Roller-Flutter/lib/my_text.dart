import 'package:flutter/material.dart';

class MyText extends StatelessWidget {

  final String txt;

  const MyText(this.txt, {super.key});
  
  @override
  Widget build(BuildContext context) {
    return Text(
      txt,
      style: TextStyle(
        color: Colors.purple,
        fontSize: 24,
        fontWeight: FontWeight.bold,
        fontFamily: 'Times New Roman',
      ),
    );
  }
}

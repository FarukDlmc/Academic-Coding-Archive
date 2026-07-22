import 'package:flutter/material.dart';

class NiceButton extends ElevatedButton {
  final AlignmentGeometry beginAlignment;
  final AlignmentGeometry endAlignment;
  final List<Color> colors = [const Color.fromARGB(255, 17, 18, 17), const Color.fromARGB(255, 241, 249, 151)];

  NiceButton({
    required this.beginAlignment,
    required this.endAlignment,
    super.key,
    required super.onPressed,
    required super.child,
  });

  NiceButton.green({
    this.beginAlignment = Alignment.topLeft,
    this.endAlignment = Alignment.bottomRight,
    super.key,
    required super.onPressed,
    required super.child, required ButtonStyle style,
  });
}
import 'package:flutter/material.dart';
import 'package:zar_at/roller.dart';
//import 'package:flutter_application_1/my_text.dart';

class BeautifulContainer extends StatelessWidget {
  final AlignmentGeometry beginAlignment;
  final AlignmentGeometry endAlignment;
  final List<Color> colors;
  final String txt;

  const BeautifulContainer(
    this.beginAlignment,
    this.endAlignment, {
    super.key,
    required this.colors,
  }) : txt = "Merhaba";
  
  const BeautifulContainer.showText(
    this.txt,
    this.colors, {
    this.beginAlignment = Alignment.topLeft,
    this.endAlignment = Alignment.bottomRight,
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    //context -> Widget ağacındaki bir widget'in konumuna ilişkin tanıtıcı.
    return Container(
      decoration: BoxDecoration(
        gradient: LinearGradient(
          colors: colors,
          begin: beginAlignment,
          end: endAlignment,
        ),
      ),
      child: Center(
        child: RollerWidget(),
      ),
    );
  }
}

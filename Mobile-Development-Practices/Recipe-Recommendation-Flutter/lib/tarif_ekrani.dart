import 'package:flutter/material.dart';
import 'package:yemek/data/tarifler.dart';
import 'package:yemek/models/yemek_tarifi.dart';

class TarifEkrani extends StatefulWidget{
  const TarifEkrani({super.key, required this.uygunTarifler, required this.ekranDegistir});

  final void Function() ekranDegistir;
  final List<YemekTarifi> uygunTarifler;

  @override
  State<TarifEkrani> createState() {
    
    return _TarifEkraniState();
  }
  
}

class _TarifEkraniState extends State<TarifEkrani>{
  
  late YemekTarifi secilenTarif;

  @override
  void initState() {
    secilenTarif = widget.uygunTarifler[0];
    super.initState();
  }
  
  @override
  Widget build(BuildContext context) {    
    return SizedBox(
      width:double.infinity,
      child: Container(
        margin: EdgeInsets.all(30),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text('Seçtiğiniz malzemeler ile yapabileceğiniz ${widget.uygunTarifler.length} tarif bulundu.'),
            const SizedBox(height:20,),
            widget.uygunTarifler.length > 1 ? 
            const Text('Lütfen bir tarif seçin.')
            : SizedBox(height: 1),
            const SizedBox(height:20,),
            DropdownButton(
              value:secilenTarif.isim,
              items: widget.uygunTarifler.map((YemekTarifi tarif) {
                return DropdownMenuItem(
                  value:tarif.isim,
                  child:Text(tarif.isim),
                );}).toList(), 
              onChanged: (newValue) {
                setState(() {
  secilenTarif=widget.uygunTarifler.firstWhere((element) =>element.isim==newValue);
                });
              }
            ),
            SizedBox(height: 20,),
            Expanded(
              child: SingleChildScrollView(
                child: Text(secilenTarif.tarif)
              ),
            ),
            SizedBox(height: 20,),
            OutlinedButton.icon(
              onPressed:widget.ekranDegistir,
              style:OutlinedButton.styleFrom(
              foregroundColor:const Color.fromARGB(255, 238, 241, 255),
              shape:const RoundedRectangleBorder(borderRadius:BorderRadius.all(Radius.circular(7))),
              side:const BorderSide(color:Color.fromARGB(38, 255, 255, 255)),
            ),
            icon:const Icon(Icons.restart_alt),
            label:const Text('Baştan Başlayalım'),
            ),
          ]          
        )
      )
    );
  }

}
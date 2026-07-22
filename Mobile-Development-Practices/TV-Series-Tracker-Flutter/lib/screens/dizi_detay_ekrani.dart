import 'package:dizi_app/data/gecici_veri.dart';
import 'package:dizi_app/models/dizi.dart';
import 'package:dizi_app/models/kategori.dart';
import 'package:flutter/material.dart';

class DiziDetayEkrani extends StatefulWidget{

  const DiziDetayEkrani({super.key, required this.dizi, required this.favoriSec});

  final Dizi dizi;
  final Function(Dizi dizi) favoriSec;
  
  @override
  State<StatefulWidget> createState() {
    return _DiziDetayEkraniState();
  }

}

class _DiziDetayEkraniState extends State<DiziDetayEkrani>{
 
  String get kategoriText{
    List l =  kategoriler.where((kategori) => widget.dizi.kategoriler.contains(kategori.id)).toList();
    List s = [];
    for(final Kategori kategori in l) {
      s.add(kategori.baslik);
    }
    return s.join(', ');
  }  

  @override
  Widget build(context){
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.dizi.baslik),
        actions: [
          IconButton(icon: widget.dizi.favoriMi ? const Icon(Icons.favorite): const Icon(Icons.favorite_outline), onPressed: (){
            setState(() {
              widget.favoriSec(widget.dizi);
            });
          },),
        ],
      ),
      body: ListView(
        padding: const EdgeInsets.all(12),
        children: [
          Image.network(widget.dizi.imageURL, height: 400, width: double.infinity, fit:BoxFit.fitHeight,),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('Oyuncular:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),              
              Expanded(child: Text(widget.dizi.oyuncular.join(', '),  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('Platformlar:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),              
              Expanded(child: Text(widget.dizi.platform.join(', '),  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('Kategoriler:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),
              Expanded(child: Text(kategoriText,  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('Sezon ve Bölümler:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),              
              Expanded(child: Text('${widget.dizi.sezonSayisi} Sezon, ${widget.dizi.bolumSayisi} Bölüm',  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('Imdb Puanı:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),              
              Expanded(child: Text(widget.dizi.imdbPuani.toString(),  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
          const SizedBox(height: 10,),
          Row(
            children: [
              Text('İzleyici Düzeyi:', style: Theme.of(context).textTheme.titleMedium!.copyWith(color: Theme.of(context).colorScheme.primary,),),
              const SizedBox(width: 10,),              
              Expanded(child: Text(widget.dizi.izleyiciDuzeyi,  style: Theme.of(context).textTheme.bodyLarge!.copyWith(color: Theme.of(context).colorScheme.onSurface),)),
            ],
          ),
        ],
      ),
    );
  }
}
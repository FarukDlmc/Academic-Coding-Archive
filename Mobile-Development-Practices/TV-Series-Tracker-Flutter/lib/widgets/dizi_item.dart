import 'package:dizi_app/models/dizi.dart';
import 'package:flutter/material.dart';
import 'package:transparent_image/transparent_image.dart';

class DiziItem extends StatelessWidget{

  const DiziItem({super.key, required this.dizi, required this.diziSec});

  final Dizi dizi;
  final void Function(Dizi dizi) diziSec;

  @override
  Widget build(context){
    return Card(
      margin: const EdgeInsets.all(8),
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(8)),
      clipBehavior: Clip.hardEdge,
      elevation: 3,
      child: InkWell(
        onTap: () {
          diziSec(dizi);
        },
        child: Stack(
          children: [
            FadeInImage(placeholder: MemoryImage(kTransparentImage), image: NetworkImage(dizi.imageURL), fit: BoxFit.cover, height: 200, width: double.infinity,),
            Positioned(
              bottom: 0,
              left: 0,
              right: 0,
              child: Container(
                padding: const EdgeInsets.symmetric(vertical: 4, horizontal: 40),
                color: Colors.black38,
                child: Column(
                  children: [
                    Text(dizi.baslik, maxLines: 2, textAlign: TextAlign.center, softWrap: true, overflow: TextOverflow.ellipsis,
                    style: const TextStyle(fontSize: 20, fontWeight: FontWeight.bold, color: Colors.white),),
                    const SizedBox(height: 10,),
                    Row(
                      children: [
                        const Icon(Icons.star),
                        const SizedBox(width: 4,),
                        Text(dizi.imdbPuani.toString(), style: const TextStyle(color: Colors.white),),
                        const Spacer(),
                        Text(dizi.platform.join(' | '), style: const TextStyle(color: Colors.white),),
                        const Spacer(),
                        const Icon(Icons.supervised_user_circle),
                        const SizedBox(width: 4,),
                        Text(dizi.izleyiciDuzeyi, style: const TextStyle(color: Colors.white),),
                      ],
                    ),
                  ],
                ),
              )),
          ],
        ),
      ),
    );
  }
}
import 'package:flutter/material.dart';

class SoyadGuncellemeEkrani extends StatefulWidget {
  final VoidCallback anaEkranaDon;
  final Function(String, String) bilgiGuncelle;
  final String mevcutDeger;

  const SoyadGuncellemeEkrani({
    super.key,
    required this.anaEkranaDon,
    required this.bilgiGuncelle,
    required this.mevcutDeger,
  });

  @override
  State<SoyadGuncellemeEkrani> createState() => _SoyadGuncellemeEkraniState();
}

class _SoyadGuncellemeEkraniState extends State<SoyadGuncellemeEkrani> {
  late TextEditingController _controller;

  @override
  void initState() {
    super.initState();
    _controller = TextEditingController(text: widget.mevcutDeger);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () => widget.anaEkranaDon(),
        ),
        title: const Text('Soyad Güncelleme'),
      ),
      body: Center(
        child: Padding(
          padding: const EdgeInsets.all(20),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextField(
                controller: _controller,
                decoration: const InputDecoration(
                  labelText: 'Yeni Soyad',
                  border: OutlineInputBorder(),
                ),
              ),
              const SizedBox(height: 20),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  ElevatedButton(
                    onPressed: () => widget.anaEkranaDon(),
                    child: const Text('Vazgeç'),
                  ),
                  ElevatedButton(
                    onPressed: () {
                      if (_controller.text.isNotEmpty) {
                        widget.bilgiGuncelle('soyad', _controller.text);
                      }
                    },
                    child: const Text('Kaydet'),
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }

  @override
  void dispose() {
    _controller.dispose();
    super.dispose();
  }
}
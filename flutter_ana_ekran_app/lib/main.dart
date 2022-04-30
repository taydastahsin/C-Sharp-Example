import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "APP Çerçevesi",
      home: AnaEkran(),
    );
  }
}

class AnaEkran extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Boş APP Çerçevesi"),
      ),
      body: Container(
        child: Center(
          child: Text("Flutter Ana Ekran APP"),
        ),
      ),
    );
  }
}

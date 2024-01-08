# ReCap

Bu proje, Entity Framework, katmanlı mimari ve local veritabanı kullanılarak geliştirilmiştir.

## Proje Tanımı

Proje, Entity Framework kullanılarak veritabanı etkileşimi sağlanmış, katmanlı mimari kullanılarak kodun modüler ve sürdürülebilir olması hedeflenmiştir.

## Gereksinimler

- Visual Studio
- .NET Core 7

## Kurulum

1. Repoyu bilgisayarınıza klonlayın.
2. Visual Studio'yu açın.
3. Proje dosyasını açın: `ProjeAdi.sln`.
4. Projeyi derleyin ve çalıştırın.

## Kullanılan Teknolojiler

- C#
- .NET Core
- Entity Framework Core

## Proje Yapısı

Proje, şu katmanlı mimariye dayanmaktadır:

- **[ReCap].Core**: Temel iş mantığı ve modeller.
- **[ReCap].Data**: Veritabanı etkileşimi için Entity Framework.
- **[ReCap].Service**: İş mantığı servisleri.
- **[Recağ].Web**: Kullanıcı arayüzü ve sunum katmanı.

## Veritabanı

Projede [LocalDB/MSSQL/SQLite] kullanılmıştır.

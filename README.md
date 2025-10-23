# RoxesKopyala

**RoxesKopyala**, Unturned sunucularında oyuncuların anlık konumlarını kolayca kopyalayıp görmelerini sağlayan basit bir RocketMod eklentisidir.  
Oyuncular `/kopyala` veya `/konum` komutunu kullanarak bulundukları koordinatları anında sohbet ekranında görebilir.

## 🎮 Özellikler
- Oyuncunun anlık X, Y, Z koordinatlarını gösterir.  
- Sohbette okunabilir ve sade formatta görüntüler.  
- Işınlanma formatını (X Y Z) ayrı olarak gösterir.  
- Hafif ve sunucu performansını etkilemez.  
- Discord veya internet bağlantısı gerektirmez.  

## 🧠 Komutlar
| Komut | Açıklama | Permission |
|-------|-----------|------------|
| `/kopyala` | Mevcut konumunuzu gösterir. | `kopyala.use` |
| `/konum` | Aynı işlevi görür (alias). | `kopyala.use` |

## ⚙️ Kurulum
1. `RoxesKopyala.dll` dosyasını `Servers/ServerName/Rocket/Plugins/` klasörüne atın.  
2. Sunucunuzu yeniden başlatın.  
3. Gerekirse `permissions.config.xml` dosyasına aşağıdaki izni ekleyin:

-- <Permission>kopyala.use</Permission>

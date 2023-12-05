using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArticleViewCounter.Migrations
{
    /// <inheritdoc />
    public partial class ArticleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfViews = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "NumberOfViews", "Title" },
                values: new object[,]
                {
                    { 1, "Murat Dinç", ".NET 8 ve C# Kasım 2023 sürümü, .NET dünyasında sadece bir sürüm yükseltmesi değil, aynı zamanda ASP.NET Core proje geliştirmenin geleceğini şekillendirecek yeniliklerle dolu bir dönüm noktasıdır. Yeni sürüm, performans iyileştirmelerinden kod yazma pratiklerine, verimliliği artıran özelliklerden geliştirici deneyimini zenginleştiren araçlara kadar bir dizi yenilik getiriyor.\r\n\r\nMakalede Primary Constructors, Collection Expressions, Default Lambda Parameters gibi dikkat çekici özelliklerin yanı sıra, daha özel alanlarda kullanılabilecek Inline Arrays ve deneysel çalışmalar için kullanabileceğimiz Experimental Attribute gibi ileri seviye konseptlere de değineceğiz. Ayrıca, C# 11'den itibaren kullanıma sunulan ancak .NET 8 ile daha geniş bir kitleye ulaşması beklenen Raw String Literals gibi özelliklerin pratik kullanımlarını inceleyeceğiz.", 0, ".NET Core: C# 12 ve .NET 8'deki Bazı Yeni Özellikler" },
                    { 2, "Enes Can Yılmaz", "Merhabalar\r\n\r\nBugün sizinle .NET Core ile ilgili kaynakları paylaşmak istiyorum. .NET Core ile ilgili kendimi geliştirdiğim kaynakları sizinle de paylaşmak istedim!\r\n\r\nBu kaynaklar, .NET Core hakkında daha fazla bilgi edinmek, projelerinizde kullanmak veya becerilerinizi geliştirmek isteyenler için son derece yararlı olabilir.\r\n\r\nUmarım bu kaynaklar, .NET Core ile ilgili yolculuğunuzda size yardımcı olur.\r\n\r\nTeşekkürler ve iyi çalışmalar!", 0, ".NET Core Öğrenme Kaynaklarım" },
                    { 3, "Ethem Boynukara", "Merhabalar,\r\n\r\nBu yazıda .NET ekosisteminin yeni framework’ü .NET Core’dan, birlikte gelen bazı yeniliklerden ve firmamızda projelerde kullanılan .NET Framework’ü ile yazılmış kütüphanenin .NET Core’a geçiş sürecininden bahsedeceğim.\r\n\r\nGöç hikayemize direk geçiş yapmak için tıklayabilirsiniz.\r\n\r\nİlk olarak .NET Framework, .NET Core, .NET Standard’ın ne olduğunu kısaca açıklayalım.", 0, ".NET Framework’ten .NET Core‘a Göç Hikayemiz" },
                    { 4, "Kübra Balaban", "Her gün yeni bir gün ve bu yeni gün ile birlikte bir sürü yenilik ile karşılaşıyoruz, taaa ki gün batımına kadar. Her gün hayatımıza bir yenisini ekleyip keşfettiğimiz teknolojiler bu teknoljilerden biri de .Net Core.\r\n\r\nYazılım sektöründe olan hızlı dönüşüm ve yenilikler ile birlikte, web uygulaması geliştirmek için bir çok teknoloji bulunmaktadır Asp .Net Core bu teknolojilerin başında gelmektedir.", 0, ".Net Core API Geliştirme" },
                    { 5, "Mehmed Emre AKDİN", "Öncelikle türkçesini “Arayazılım/Arakatman” olarak çevirebileceğimiz middleware kavramı sadece ASP.NET Core’a özgü bir kavram değildir. Genel olarak WEB mimarilerinde request(istek)’den, response(cevap)’a kadar gerçekleşen süreç middleware olarak adlandırılır. Eğer ASP.NET Core içinde bir tanımlama yapmamız gerekirse, uygulamamıza gelen HTTP request(istek) ve response(cevap) ‘ larını işlememize olanak sağlayan C# sınıflardır demek doğru olacaktır. Bunu bir nevi filtreleme işlemi olarak düşünebilirsiniz. Yani normal bir süreçte uygulamamıza gelen istekler, tanımlanan middleware ‘lerden geçerek uygulamamıza ulaşır, uygulamamızın cevabı oluşturulduktan sonra bu cevap yine tanımlanan middleware ’lerden geçerek kaynağa ulaşır ve süreç tamamlanır. Middleware‘ler dememden anlayacağınız üzere birden çok tanımlanabilirler ve çeşitli amaçlarla kullanılırlar. Aklımızda bazı şeylerin hafiften şekillenmeye başlaması için middleware‘lerin kullanılabileceği bazı alanlara örnekler vermek istiyorum:", 0, "ASP.NET Core Middleware Nedir?" },
                    { 6, "Eren Yılmaz", "Herkese selamlar, bugün bir başka içerik ile karşınızdayım. 🙂\r\n\r\nBu yazımda, sizlere bir micro orm aracı olan “Dapper” ile ilgili bilgi vermeye çalışacağım.\r\n\r\nÖnceki yazılarımı takip edenler hatırlayacaktır, SOLID prensiplerine dikkat ederek geliştirmeye başladığım bir projeyi, Entity Framework orm aracını kullanarak veri tabanı üzerinde işlemler yapacak şekilde kodlamıştım. Bu içeriği merak edenler, buradan makaleye erişebilirler.\r\n\r\nDapper orm aracını projeye implemente edecek, ve bu işlemden sonra projemizi Entity Framework üzerinden Dapper’a geçireceğiz. Bu işlemi yaparken, SOLID prensiplerine uygun kodlama yapmanın bize ne kadar avantaj sağladığını deneyimlerek göreceğiz.", 0, ".Net Core — Dapper İmplementasyonu" },
                    { 7, "Veysel Mutlu", "Serilog , .NET uygulamaları için en popüler Log kitaplıklarından(libraries) birisidir. Kurulumu kolaydır ve çok sayıda güçlü özellik sunar. Yazılım geliştiricilerin özelleştirilmiş kodlarını buna eklemelerine ve bu kitaplığın işlevselliğini daha da genişletmelerine olanak tanıyan birçok uzantı noktasına sahiptir. Bu makale sonunda, metin tabanlı Log dosyalarına nasıl mesaj kaydedebileceğinizi göstereceğim.\r\n\r\nSerilog nedir?\r\nYazılım uygulamalarının en can alıcı noktalarından biri işleyişteki her bir adımı raporlayıp kayıt altına alan log mekanizmalarıdır diyebiliriz. Serilog , uygulamanıza bazı harika tanılama özellikleri eklemek için kullanılabilecek .NET uygulamaları için yapısal bir log kitaplığıdır(library).\r\n\r\nYazılım geliştiricilerin dosyalara, consola, veri tabanlarına ve mesaj kuyruklarına dahil olmak üzere yüzlerce farklı hedefe mesajlarını kaydetmelerine olanak tanır.", 0, "ASP.NET Core — Serilog İle Veri Loglama" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}

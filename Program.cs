var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "🔥 Empire Server - mbreem is Running!");

// 1 - فحص السيرفر
app.MapGet("/api/status", () => new {
    server = "mbreem Empire",
    status = "Online",
    time = DateTime.Now
});

// 2 - قاعدة الأجهزة
app.MapGet("/api/devices", (string? model) => {
    var devices = new[] {
        new { model = "SM-A245F", chip = "Exynos 1280", mode = "Download", brand = "Samsung", android = "14" },
        new { model = "SM-A155F", chip = "Helio G99", mode = "Download", brand = "Samsung", android = "14" },
        new { model = "22126RN91Y", chip = "Snapdragon 685", mode = "Fastboot", brand = "Xiaomi", android = "13" },
        new { model = "SM-G990", chip = "Snapdragon 8 Gen 1", mode = "Download", brand = "Samsung", android = "14" }
    };

    if (string.IsNullOrEmpty(model)) return Results.Ok(devices);
    var result = devices.Where(d => d.model.Contains(model, StringComparison.OrdinalIgnoreCase));
    return Results.Ok(result);
});

// 3 - فحص الترخيص
app.MapGet("/api/check-license", (string? key) => {
    if (key == "MBREEM-DEMO-2026")
        return Results.Ok(new { valid = true, user = "mbreem", expire = "2027-09-17" });
    return Results.Ok(new { valid = false, message = "كود خاطئ" });
});

// 4 - التحديثات
app.MapGet("/api/update", () => new {
    latest = "1.0.0",
    downloadUrl = "https://github.com/mohomedbream/mbreem/releases",
    note = "اول اصدار من سيرفر mbreem"
});

app.Run();

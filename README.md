# 🛍️ Product Viewing API

API RESTful desenvolvida com **.NET 8** para fornecer produtos paginados com suporte a autenticação via API Key. 

---

## 🚀 Tecnologias Utilizadas

- ✅ ASP.NET Core 8
- ✅ Clean Architecture
- ✅ Princípios SOLID
- ✅ In-Memory Repository (Mock)
- ✅ API Key Middleware

---

## ▶️ Como Rodar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/WelvisSS/product_viewing_api.git
cd product_viewing_api
```

### 2. Compile a solução
```bash
dotnet build
```


### 3. Execute o projeto:
```bash
dotnet run --project src/ProductViewing.API 
```

### Você pode definir a chave em:

📄 appsettings.json:

```bash
{
  "ApiKey": "minha-chave-secreta"
}
```


## 📦 Exemplo de Requisição

**GET /api/products?page=1&pageSize=6**

###  Headers:
```bash
X-API-KEY: minha-chave-secreta
```

### Response:
```bash
{
  "items": [
    {
      "id": 1,
      "name": "Camisa",
      "price": 59.90,
      "imageUrl": "https://img.exemplo.com/photo-1"
    }
  ],
  "totalCount": 23,
  "page": 1,
  "pageSize": 6
}
```

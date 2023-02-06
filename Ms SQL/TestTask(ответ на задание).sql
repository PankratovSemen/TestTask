SELECT prod.Id,prod.Name,prod.price,cat.NameCategory
FROM dbo.Products prod
LEFT JOIN dbo.Category cat ON prod.IdCategory = cat.Id
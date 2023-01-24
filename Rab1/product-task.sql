SELECT products.name as 'Имя продукта', categories.name as 'Имя категории'
FROM products
LEFT JOIN product_categories ON products.id = product_categories.product_id
LEFT JOIN categories ON product_categories.category_id = categories.id




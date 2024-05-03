select p.name, c.name from products p
left join product_categories pc on p.id = pc.product_id 
left join categories c on pc.category_id = c.id 
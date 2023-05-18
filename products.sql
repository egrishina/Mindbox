SELECT
  p.product_name,
  c.category_name
FROM
  products AS p
  LEFT JOIN products_categories AS pc ON (p.product_id = pc.product_id)
  LEFT JOIN categories AS c ON (pc.category_id = c.category_id)
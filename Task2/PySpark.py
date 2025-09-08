from pyspark.sql import SparkSession
from pyspark.sql.functions import col

spark = SparkSession.builder.master("local[*]").appName("ProductsCategories").getOrCreate()

products = spark.createDataFrame([
    (1, "Яблоко"),
    (2, "Груша"),
    (3, "Хлеб"),
    (4, "Молоко"),
], ["product_id", "product_name"])

categories = spark.createDataFrame([
    (1, "Фрукты"),
    (2, "Выпечка"),
], ["category_id", "category_name"])

product_category = spark.createDataFrame([
    (1, 1), 
    (2, 1),
    (3, 2),
], ["product_id", "category_id"])

def product_category_pairs(products, categories, product_category):
    """
    Возвращает датафрейм со всеми парами "Имя продукта – Имя категории"
    и продуктами без категорий (категория = None).
    """
    return (products
        .join(product_category, on="product_id", how="left")
        .join(categories, on="category_id", how="left")
        .select("product_name", "category_name")
    )

result = product_category_pairs(products, categories, product_category)

result.show(truncate=False)

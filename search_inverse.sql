declare @search_value as nVarChar = 'j'

SELECT        id, first_name, last_name, customer_id, income, debt, birth_date, gender, education, study_field, cell_phone1, cell_phone2, landline1, landline2, fax, email, web_url, country, state, city, zip_code, address1, address2, co_name, 
                         activity, comment, customer_image
FROM            phone_book_table
WHERE        (last_name is null or CHARINDEX(@search_value, last_name, 0) = 0) AND (first_name is null or CHARINDEX(@search_value, first_name, 0) = 0) AND (co_name is null or CHARINDEX(@search_value, co_name, 0) = 0)
ORDER BY last_name, co_name

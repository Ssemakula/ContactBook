SELECT        id, first_name, last_name, customer_id, income, debt, birth_date, gender, education, study_field, cell_phone1, cell_phone2, landline1, landline2, fax, email, web_url, country, state, city, zip_code, address1, address2, co_name, 
                         activity, comment, customer_image
FROM            phone_book_table
WHERE        (last_name LIKE @search_value) OR
                         (first_name LIKE @search_value) OR
                         (co_name LIKE @search_value)
ORDER BY last_name, co_name
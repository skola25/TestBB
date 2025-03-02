
/****** Object:  View [dbo].[qtrly_sales_comm_earned_v]    Script Date: 3/2/2025 6:01:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[qtrly_sales_comm_earned_v]
as
with main as
(select s_fact.s_id sales_id,
       p.commission_perc comm_perc,
      concat(sp.first_name,' ',sp.last_name) sales_person,
       p.prod_name,
	  -- concat(cust.first_name,' ',cust.last_name) Customer,
	   s_fact.Sales_Date Sales_Date,
	   dis.discount_perc,
       count(s_fact.prod_id) items_sold,
	   (count(s_fact.prod_id)*sum(p.Sale_Price*(dis.Discount_Perc*0.01))) disc_given,
	   sum(p.Sale_Price)-(count(s_fact.prod_id)*sum(p.Sale_Price*(dis.Discount_Perc*0.01))) final_price
from salesperson sp,
     sales s_fact,
	 products p,
	 customer cust,
	 DISCOUNT dis
 where sp.sp_id=s_fact.sp_id
	 and s_fact.prod_id=p.prod_id
	 and s_fact.cust_id=cust.cust_id
	 and s_fact.prod_id=dis.prod_id
	 and p.prod_id=dis.prod_id
  Group by s_fact.s_id,
           p.commission_perc,
		   dis.discount_perc,
	       concat(sp.first_name,' ',sp.last_name),
           p.prod_name,
	      -- concat(cust.first_name,' ',cust.last_name),
	       s_fact.Sales_Date
	   )
select m.sales_person,
       --m.customer,
	   m.prod_name,
       DATEPART(QUARTER,m.sales_date) AS Quarterly,
	   sum(m.final_price*(m.comm_perc*0.01)) Commission_Earned
from main m
 group by m.sales_person,
       --m.customer,
	   m.prod_name, DATEPART(QUARTER,m.sales_date)
GO



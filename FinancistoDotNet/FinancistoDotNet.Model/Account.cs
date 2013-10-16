using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancistoDotNet.Model
{
//@Entity
//@Table(name = "ACCOUNT")
public class Account : MyEntity {
	
	//@Column(name = "creation_date")
	public DateTime creationDate = DateTime.Now;

    //@Column(name = "last_transaction_date")
    public DateTime lastTransactionDate = DateTime.Now;

    @JoinColumn(name = "currency_id")
	public Currency currency;

	@Column(name = "type")
	public String type = AccountType.CASH.name();
	
	@Column(name = "card_issuer")
	public String cardIssuer;

	@Column(name = "issuer")
	public String issuer;
	
	@Column(name = "number")
	public String number;
	
	@Column(name = "total_amount")
	public long totalAmount;
	
	@Column(name = "total_limit")
	public long limitAmount;

	@Column(name = "sort_order")
	public int sortOrder;
	
	@Column(name = "is_active")
	public boolean isActive = true; 

	@Column(name = "is_include_into_totals")
	public boolean isIncludeIntoTotals = true; 
	
	@Column(name = "last_account_id")
	public long lastAccountId;

	@Column(name = "last_category_id")
	public long lastCategoryId;
	
	@Column(name = "closing_day")
	public int closingDay;
	
	@Column(name = "payment_day")
	public int paymentDay;

    @Column(name = "note")
    public String note;

    public boolean shouldIncludeIntoTotals() {
        return isActive && isIncludeIntoTotals;
    }
}
}

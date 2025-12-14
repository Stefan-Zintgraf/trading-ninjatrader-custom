**Path**: [User-Based Vendor Licensing](./user_based_licensing.md) > [Quick-Start Guide](./user_based_licensing_quick_start_guide.md)

# Quick-Start Guide

# Quick\-Start Guide

## [Accessing the NinjaTrader Ecosystem Vendor Dashboard](./user_based_licensing_quick_start_guide.md)

To distribute an indicator, you must first access the [NinjaTrader Ecosystem vendor dashboard](https://ecosystem.ninjatrader.com/).

If you are new to NinjaTrader, access to the vendor dashboard has been given to you as part of the new vendor onboarding process.

If you have an existing NinjaTrader account, request access to the vendor dashboard by sending your username to [Vendor Support](https://vendor-support.ninjatrader.com/s/contactsupport?language=en_US).

## [Adding Products in the Vendor Dashboard](./user_based_licensing_quick_start_guide.md)

Once you have access to the vendor dashboard, you must create the product and copy the product ID (to use in the next step).

1.  Create your add\-on in the **Manage Add\-Ons** screen.
2.  Copy the add\-on’s product ID.

![](https://cdn.sanity.io/images/1hlwceal/production/9989b0ecc2436112e3031f7b85d30072389e417d-807x918.png?fit=max&w=500&h=500)

## [Linking the product in the UI to the add\-on in NinjaTrader desktop](./user_based_licensing_quick_start_guide.md)

Once the product is created in the vendor dashboard, you must link it to the add\-on you created in NinjaTrader desktop.

1.  In NinjaTrader desktop, open NinjaScript Editor.
2.  From the Control Center, click **New** > **NinjaScript Editor**.
3.  In the NinjaScript Explorer pane, open the add\-on that you just created in the NinjaTrader Ecosystem vendor dashboard.
    *   If it opens in a new window (for example, Strategy Builder), click **View Code**.
4.  Find the line with `VendorLicense` and replace it with the following, making sure to add the product ID that was just created:
    *   `VendorLicense(/*Your Product ID*/)` If your add\-on does not have a VendorLicense line, add the following to your NinjaScript file, making sure to add the product ID that was just created:

```csharp
namespace NinjaTrader.NinjaScript.Strategies
{
	public class TestExportStrategy : Strategy
	{
		public TestExportStrategy()
		{
			VendorLicense(/*Your Product ID*/);
		}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

5.  Save and compile the code.
6.  Export the updated file to distribute for new licenses.

## [Adding a License for a Customer](./user_based_licensing_quick_start_guide.md)

Now that the product is linked in the vendor dashboard and NinjaTrader desktop, you are ready to create a customer license. You can do this either through the vendor dashboard or by using the API.

### Adding a customer license through the vendor dashboard

1.  From the **Manage Add\-Ons** screen, find the add\-on and click **Edit**.
2.  Under **Licenses**, click **Add License**.
3.  Add the user’s email address, select the license type, and then click **Create License**.
4.  Review the details of the new license and then click **Confirm**.

### Adding a customer license through the API

For more information, see the [NinjaTrader Ecosystem API Documentation](https://developer.ninjatrader.com/docs/ecosystem).

## [Free Trials](./user_based_licensing_quick_start_guide.md)

When you create an add\-on, you can set how long free trials last. Users are limited to one free trial per product. If you have a free trial configured, customers using your product for the first time will be granted a free trial.

Free trials start the day a customer first uses your product and end after the number of free trial days has passed.

If you need to create a free trial for a user who already had a trial, you can create a temporary license using the _Adding a License for a Customer_ process. Under **License Type**, select _Free Trial_.

## [Enabling Authentication](./user_based_licensing_quick_start_guide.md)

The vendor license check is added in your code as a method call in NinjaTrader 8.1.5.0 or later.

The following is the _VendorLicense_ class constructor:

```csharp
VendorLicense(productID)

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Any time an add\-on is used, NinjaTrader checks the user’s license. If the user doesn’t have a license, the OnBarUpdate() and Plot() methods will not be called in the Strategy. However, the script will still process any code within its SetDefaults State. Thus, if you have added any code within an “if (State == State.SetDefaults)” condition in the OnStateChange() method, this will be processed regardless of a user’s license status.

## [Protection and DLL Security](./user_based_licensing_quick_start_guide.md)

NinjaTrader uses Agile.net to offer increased security for protected DLLs. This requires a yearly license fee which can be paid directly to SecureTeam. For more information, see [SecureTeam pricing](http://www.secureteam.net/ninja-pricing) and the [Protection / DLL Security section of the help guide](https://ninjatrader.com/support/helpGuides/nt8/en-us/?protection_dll_security.htm).

## [Have Questions?](./user_based_licensing_quick_start_guide.md)

*   [User\-Based Licensing Migration Guide](./user_based_licensing_migration_guide.md)
*   [User\-Based Licensing FAQ](./user_based_licensing_faq.md)
*   [NinjaTrader Distribution Procedure](./distribution_procedure.md)
*   [Vendor Support](https://vendor-support.ninjatrader.com/s/contactsupport?language=en_US)

#### ON THIS PAGE

*   [Accessing the NinjaTrader Ecosystem Vendor Dashboard](./user_based_licensing_quick_start_guide.md)
*   [Adding Products in the Vendor Dashboard](./user_based_licensing_quick_start_guide.md)
*   [Linking the product in the UI to the add\-on in NinjaTrader desktop](./user_based_licensing_quick_start_guide.md)
*   [Adding a License for a Customer](./user_based_licensing_quick_start_guide.md)
*   [Free Trials](./user_based_licensing_quick_start_guide.md)
*   [Enabling Authentication](./user_based_licensing_quick_start_guide.md)
*   [Protection and DLL Security](./user_based_licensing_quick_start_guide.md)
*   [Have Questions](./user_based_licensing_quick_start_guide.md)
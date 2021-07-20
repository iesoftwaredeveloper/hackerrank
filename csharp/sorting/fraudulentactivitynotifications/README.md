# Fraudulent Activity Notifications

Problem: <https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting>

## Goal

Be able to identify when an expenditure for a particular day is greater than the median for the previous *d* days.

For example, if you have a total of 8 days expenditures and you want to perform a lookback for 3 days.

The first three days would not perform any expenditure comparisons.

On the fourth day, the median of the first three days would be computed.  If the expenditures on the 4th day were greater than the median of the previous 3 days, it would trigger a notification.

## Intial Approach

The key here is that you need to keep a running median of the previous *d* days so that you can quickly do a comparison against the current days expenditure.

To compute a median you need to sum the total and divide by the number of elements.

Using an array (or list) to store the median values will allow a quick lookup.

The lookup will be the current day minus the number of lookback days *d*. If we have a total of 3 lookback days and we are on day 4, then the median would be stored in the current expenditure index (3) - the number of lookback days (3).  This would be index zero.

The size of the array to store median expenditures in is the number of expenditures - the lookback days.


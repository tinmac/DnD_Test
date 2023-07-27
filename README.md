# Winui 3 Project demonstrating ListView reorder issue.

### Issue: Two items are selected after reorder.

How to replicate issue
- Select Item 1
- Reorder item 2 above item 1
- repeat a couple of times and both items 1 & 2 will be selected - SelectionMode="Single"

![gif](https://github.com/tinmac/DnD_Test/blob/master/DnD_Test/ListView_Reorder_Issue_AdobeExpress.gif)


### Expected behaviour
- Only the original selected item should be selected, reordering should not produce two selected items

- net6.0-windows10.0.19041.0
- Microsoft.WindowsAppSDK  1.3.230502000
- Windows 11 22H2 22621.1992

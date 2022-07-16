let storage = localStorage;
function doFirst() {
    let itemString = storage['addItemList'] //let itemString =storage.getItem['addItemList']
    let items = itemString.substr(0, itemString.length - 2).split(', ')
    let newDiv = document.createElement("div")
    let newTable = document.createElement("table")
    //將table放進div 再放進 cartList
    newDiv.appendChild(newTable);
    document.getElementById("cartList").appendChild(newDiv);
    let total = 0;
    for (let i = 0; i < items.length; i++) {
        let itemInfo = storage.getItem(items[i]);
        console.log(itemInfo);
        createCartList(items[i], itemInfo)

        let itemPrice = parseInt(itemInfo.split('|')[2]);
        total += itemPrice;

    }
    document.getElementById("total").innerText = total;
    function createCartList(itemId, itemValue) {
        // alert(`${itemId}: ${itemValue}`);
        let itemImage = "imgs/" + itemValue.split('|')[1];
        let itemTitle = itemValue.split('|')[0];
        let itemPrice = parseInt(itemValue.split('|')[2]);
        //建立每個品項的清單區域--tr

        let trItemList = document.createElement("tr");
        trItemList.className = "item";
        newTable.appendChild(trItemList);

        //建立圖片--td
        let tdImage = document.createElement("td");
        tdImage.style.width = '200px'
        let image = document.createElement("img");
        image.src = itemImage;
        image.width = "80"
        tdImage.appendChild(image);
        trItemList.appendChild(tdImage);


        //建立名稱跟刪除按鈕--td
        let tdTitle = document.createElement("td");
        tdTitle.style.width = '200px';
        tdTitle.id = itemId;
        let pTitle = document.createElement("p");
        pTitle.innerText = itemTitle;
        let deleteBtn = document.createElement("button");
        deleteBtn.innerText = "Delete";
        deleteBtn.addEventListener("click", deleteItem)

        tdTitle.appendChild(pTitle);
        tdTitle.appendChild(deleteBtn);

        trItemList.appendChild(tdTitle);

        //建立價格--td
        let tdPrice = document.createElement("td")
        tdPrice.style.width = '170px'
        let pPrice = document.createElement("p")
        pPrice.innerText = itemPrice
        tdPrice.appendChild(pPrice)
        trItemList.appendChild(tdPrice)
        //建立數量--td
        let tdCount = document.createElement("td")
        tdCount.style.width = '60px'
        let pItemCount = document.createElement("p")
        let inputItemCount = document.createElement("input")
        inputItemCount.type = 'number'
        inputItemCount.value = 1
        inputItemCount.min = 1
        inputItemCount.addEventListener('input', changeCount)
        pItemCount.appendChild(inputItemCount)
        tdCount.appendChild(pItemCount)
        trItemList.appendChild(tdCount)
    }
    function deleteItem(e) {
        let itemId = e.target.parentNode.id
        // 先扣除總金額，若要
        let itemValue = storage.getItem(itemId)
        total -= parseInt(itemValue.split('|')[2])
        document.getElementById("total").innerText = total
        //storage 清除
        storage.removeItem(itemId)
        // 1.
        storage['addItemList'] = storage['addItemList'].replace(`${itemId}, `, ``)
        // 2.
        let valueTemp = storage.getItem("addItemList")
        let valueResult = valueTemp.replace(`${itemId}, `, ``)
        storage.setItem("addItemList", valueResult)
        //刪除該筆tr
        // 1.
        // e.target.parentNode.parentNode.parentNode.removeChild(e.target.parentNode.parentNode)
        // 2.
        newTable.removeChild(e.target.parentNode.parentNode)
    }

    function changeCount() {
        // 作業
    }
}
window.addEventListener('load', doFirst);
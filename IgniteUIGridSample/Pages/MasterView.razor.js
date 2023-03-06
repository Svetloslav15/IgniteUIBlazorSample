//In JavaScript:
igRegisterScript("PriceCellTemplate", (ctx) => {
    var html = window.igTemplating.html;

    return html`
        <label>
            Enter the new price tag
        </label>
        <input name="price" type="number" value="${ctx.cell.value}" onchange="${this.updateValue(ctx.cell.value)}"  />
    `;
}, false);

function updateValue(value) {
    console.log(value)
    value += 1;
}
window.getTableRowFitCount = (containerSelector, rowSelector) => {
    const container = document.querySelector(containerSelector);
    const row = document.querySelector(rowSelector);
    if (!container || !row) return 10; // fallback

    // Find the table header (thead) inside the container
    const thead = container.querySelector('thead');
    const headerHeight = thead ? thead.offsetHeight : 0;

    const containerHeight = container.clientHeight;
    const rowHeight = row.offsetHeight;
    if (!rowHeight) return 10;

    // Subtract header height from container height
    const availableHeight = containerHeight - headerHeight;
    return Math.floor(availableHeight / rowHeight);
};

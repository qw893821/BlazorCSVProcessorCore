function SaveFileAs(filename, content) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:text/plain;charset=uft-8," + encodeURIComponent(content);
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
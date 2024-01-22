<template>
  <div class="input-group mb-3">
    <span class="input-group-text" id="basic-addon1">@</span>
    <input
      type="text"
      class="form-control"
      placeholder="Username"
      aria-label="Username"
      aria-describedby="basic-addon1" />
  </div>

  <div class="input-group mb-3">
    <input
      type="text"
      class="form-control"
      placeholder="Recipient's username"
      aria-label="Recipient's username"
      aria-describedby="basic-addon2" />
    <span class="input-group-text" id="basic-addon2">@example.com</span>
  </div>

  <div class="mb-3">
    <label for="basic-url" class="form-label">Your vanity URL</label>
    <div class="input-group">
      <span class="input-group-text" id="basic-addon3">
        https://example.com/users/
      </span>
      <input
        type="text"
        class="form-control"
        id="basic-url"
        aria-describedby="basic-addon3 basic-addon4" />
    </div>
    <div class="form-text" id="basic-addon4">
      Example help text goes outside the input group.
    </div>
  </div>

  <div class="input-group mb-3">
    <span class="input-group-text">$</span>
    <input
      type="text"
      class="form-control"
      aria-label="Amount (to the nearest dollar)" />
    <span class="input-group-text">.00</span>
  </div>

  <div class="input-group mb-3">
    <input
      type="text"
      class="form-control"
      placeholder="Username"
      aria-label="Username" />
    <span class="input-group-text">@</span>
    <input
      type="text"
      class="form-control"
      placeholder="Server"
      aria-label="Server" />
  </div>

  <div class="input-group">
    <span class="input-group-text">With textarea</span>
    <textarea class="form-control" aria-label="With textarea"></textarea>
  </div>

  <!-- Button trigger modal -->
  <button
    type="button"
    class="btn btn-primary"
    data-bs-toggle="modal"
    data-bs-target="#staticBackdrop">
    Launch static backdrop modal
  </button>

  <!-- Modal -->
  <div
    class="modal fade"
    id="staticBackdrop"
    data-bs-backdrop="static"
    data-bs-keyboard="false"
    tabindex="-1"
    aria-labelledby="staticBackdropLabel"
    aria-hidden="true">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="staticBackdropLabel">Modal title</h1>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"></button>
        </div>
        <div class="modal-body">...</div>
        <div class="modal-footer">
          <button
            type="button"
            class="btn btn-secondary"
            data-bs-dismiss="modal">
            Close
          </button>
          <button type="button" class="btn btn-primary">Understood</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "HelloWorld",
  props: {},
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped></style>
